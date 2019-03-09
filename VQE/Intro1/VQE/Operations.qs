﻿// MAIN VARIATIONAL QUANTUM EIGENSOLVER CODE
// AUTHOR: CHRISTOPHER KANG, UNIVERSITY OF WASHINGTON
// 490Q, KRYSTA SVORE, WI 2019

namespace VQE
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Chemistry.JordanWigner; 
    open Microsoft.Quantum.Chemistry;

    operation arbitrary_test(data : JordanWignerEncodingData) : ((Int[], Double[]), Int[]) {
        let (nSpinOrbitals, fermionTermData, statePrepData, energyOffset) = data!;
        // Message($"{prep_gateset(fermionTermData)}");
        // return prep_gateset(fermionTermData);
        // let ((gates, phases), targets) = (TrotterStepOracle(data))!;
        // return ((gates, phases), targets);
        // return (TrotterStepOracle(data))!;
    }

    operation main(data : JordanWignerEncodingData) : Double[][] {
        mutable out_val = new Double[][2];
    }

    operation create_generator (qSharpData : JordanWignerEncodingData) : EvolutionGenerator {
        
        // Depack the data from the JWEncoding
        // We really only need the fermionic info
        let (nSpinOrbitals, data, statePrepData, energyShift) = qSharpData!;

        // we convert the h terms into a generator system (Int, Int -> GeneratorIndex)
        // essentially, we make it so that the GeneratorIndexes are indexed, 
        // and that the phase + the targets are in the GeneratorIndex format
        let generatorSystem = JordanWignerGeneratorSystem(data);

        // We then create an EvolutionGenerator (EvolutionSet, GeneratorSystem) that allows
        // specific h-terms to be mapped with their Pauli equivalents (as defined in the evolutionset)
        // FLAG - BELIEVE THAT THE JWFERMIONEVOLUTIONSET SHOULD NOT BE USED
        // A CUSTOM MADE ONE SHOULD BE USED, INSTEAD
        let evolutionGenerator = EvolutionGenerator(JordanWignerFermionEvolutionSet(), generatorSystem);

        // let (evolutionSet, generator) = evolutionGenerator!; 
        // split into the generatorIndex => EvolutionUnitary and Int, Int => generatorIndex 
        // or a collection of generator indexes

        // EvolutionUnitary performs ((Double, Qubit[]) => Unit)

        // let (nTerms, generatorSystemFunction) = generator!; 
        // split into the number of terms and the function that turns a specific index to the generator index

        // let generatorIndex = generatorSystemFunction(0);
        // pull the 0th element of the terms (1st term)
        // (evolutionSet!(generatorIndex))!(1, qubits);
        // Message($"{(evolutionSet!(generatorIndex))!}");
        // Message($"{(JordanWignerFermionEvolutionSet())!}");
        // we need to unwrap the generatorIndex => EvolutionUnitary function
        // let simulationAlgorithm = (TrotterSimulationAlgorithm(trotterStepSize, trotterOrder))!;
        // let oracle = simulationAlgorithm(trotterStepSize, evolutionGenerator, _);
        // let nTargetRegisterQubits = nSpinOrbitals;
        // let rescaleFactor = 1.0 / trotterStepSize;
        // return generatorIndex;
        // Message($"{generatorIndex}");
        return evolutionGenerator;
    }

    operation Simulate (data : JordanWignerEncodingData, precision : Double, moe : Double) : Unit {
        Message("BEGINNING SIMULATION");

        // Create the main data source (EvolutionGenerator) with which to feed the VQE
        // This contains the data needed to construct specific terms
        let ham_terms = create_generator(data);

        mutable out_val = 0.0;
        mutable ground_energy = 1000.0;
        mutable ground_phase = 3.0;

        using (testQ = Qubit()) {
            mutable phi = 0.0;
            repeat {
                Message($"Testing phase: {phi}");
                let initial_oracle = Rx(4.0 * PI() * phi, _);
                let discovered_energy = SumExpectedValues(initial_oracle, ham_terms, testQ, moe);
                set phi = phi + precision;
                if (discovered_energy < ground_energy) {
                    set ground_energy = discovered_energy;
                    set ground_phase = phi;
                }
            } until (phi > 2.0)
            fixup {

            }
        }
        Message($"Ground energy: {ground_energy}");
        Message($"Ground state: {ground_phase}");
    }

    operation make_terms (data : EvolutionGenerator, index : Int) : ((Qubit[] => Unit : Adjoint, Controlled), (Pauli[]), Double) {
        // FLAG: MAKE THIS OPERATION WHICH GOES THROUGH THE EVOLUTION GENERATOR AND CREATES 
        // THE NECESSARY GATE COMBOS + PAULI BASES TO USE FOR THE FUTURE METHODS
    }


    operation SumExpectedValues(initial_oracle : (Qubit[] => Unit), 
                                HamiltonianGates : EvolutionGenerator, 
                                ancilla[] : Qubit, moe : Double) : Double {
        // Sum the total expected values over all terms of a hamiltonian 
        // with a given oracle that produces the starting state

        // total expectation value found 
        mutable total = 0.0;

        // we need to unpack the evolutionSet to use and the generator
        let (evolutionSet, generator) = (HamiltonianGates)!;

        // we extract the total number of terms and the indexing function
        let (num_of_terms, jw_term_indexer) = (generator)!;

        // we now iterate through each of the terms
        for (i in 0..num_of_terms - 1) {
            // and take the specified term (which is of type GeneratorIndex)
            let jw_term = jw_term_indexer(i);
            let (gate_set, basis, weight) = make_terms(HamiltonianGates, i);
            set total = total + weight * FindExpectedValue(initial_oracle, gate_set, basis, ancilla, moe);
        }
        return total;
    }

    operation FindExpectedValue(InitialStateOracle : (Qubit[] => Unit), 
                                gate : (Qubit[] => Unit), measure_basis : Pauli[],
                                ancilla : Qubit[], moe : Double) : Double {
        // repeatedly measures an operator until it's expected value is predicted within a 
        // margin of error! 

        // confidence with which to produce intervals. 1.96 for 95% confidence
        let Z_SCORE = 1.96;

        // value to be returned 
        mutable out_val = -10.0;
        
        // running total of "One"s measured
        mutable run_sum = 0.0;

        // total runs
        mutable total_runs = 0.0;

        // current unpredictability of the estimate
        mutable error_term = 1.0;

        repeat {
            for (i in 0..10) {
                // run a single iteration and see if the output is a one
                if (RunSingleIteration(InitialStateOracle, gate, measure_basis, ancilla)) {
                    // We have measured a "One"
                    set run_sum = run_sum + 1.0;
                }
                set total_runs = total_runs + 1.0;
            }

            // recreate the probability distribution
            set out_val = run_sum / total_runs;

            // calculate the current margin of error
            set error_term = MarginOfError(out_val, total_runs, Z_SCORE);
        } until (error_term < moe)
        fixup {}

        // Recognize that this probability is the probability we have achieved a one
        // thus, we can obtain the expected value with this formula
        // P(0) * 1 + P(1) * -1 = (1-P(1)) * 1 - P(1) = 1 - 2 * P(1)
        return 1.0 - 2.0 * out_val;
    }

    function MarginOfError(probability : Double, runs : Double, Z_SCORE : Double) : Double {
        // follows the information found on
        // "Confidence Interval for a Proportion in One Sample"
        return Z_SCORE * Sqrt(probability * (1.0 - probability) / runs);
    }

    operation RunSingleIteration(InitialStateOracle : (Qubit[] => Unit),
                                 MysteryGate : (Qubit[] => Unit), basis : Pauli[], ancilla : Qubit[]) : Bool {
        // given an oracle to create an arbitrary state, 
        // let us identify the expecatation value of the state with an arbitrary gate
        // and the gate's basis 

        // prepare the sample eigenstate
        InitialStateOracle(ancilla);

        // apply the gate that we want to estimate the expected value of
        MysteryGate(ancilla);

        // return true if the output value is one; false if the output value is zero
        // when we have true, we have measured an eigenvalue of -1; false is +1
        let out_val = Measure(basis, ancilla) == One ? true | false;

        // reset the ancilla so that it can be used immediately after
        ResetAll(ancilla);

        return out_val;
    }

        // function prep_gateset(data : JWOptimizedHTerms) : GeneratorSystem {
    //     // based off code for the Trotter Step Oracle
    //     let (ZData, ZZData, PQandPQQRData, h0123Data) = data!;
    //     let ZGenSys = HTermsToGenSys(ZData, [0]);
    //     let ZZGenSys = HTermsToGenSys(ZZData, [1]);
    //     let PQandPQQRGenSys = HTermsToGenSys(PQandPQQRData, [2]);
    //     let h0123GenSys = HTermsToGenSys(h0123Data, [3]);
    //     return SumGeneratorSystems([ZGenSys, ZZGenSys, PQandPQQRGenSys, h0123GenSys]);
    // }
}
