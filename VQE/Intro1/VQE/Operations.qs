namespace VQE
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation HelloQ (precision : Double, moe : Double) : Unit {
        Message("BEGINNING SIMULATION");

        using (testQ = Qubit()) {
            for (phi in 0.0..precision..2.0) {
                let initial_oracle = Rx(4.0 * PI() * phi, _);
                // SumExpectedValues(initial_oracle,  , testQ, moe);
            }
        }
    }

    operation SumExpectedValues(initial_oracle : (Qubit => Unit), 
                                HamiltonianGates : (Qubit => Unit)[], ancilla : Qubit, moe : Double) : Double {
        mutable total = 0.0;
        for (gate in HamiltonianGates) {
            set total = total + FindExpectedValue(initial_oracle, gate, ancilla, moe);
        }
        return total;
    }

    // CURRENT WORK:
    // WE NEED TO FIND A WAY TO IMPLEMENT A CHANGING SCHEME FOR FINDING THE INNER PRODUCT 
    // DEPENDENT ON THE GATESET THAT'S BEING USED

    // operation RotationStatePrep(angle : Double, rotation : ((Double, Qubit) => Unit)) : (Qubit => Unit) {
    //     return rotation(angle, _);
    // }

    operation ProduceInnerProduct(zero_prob : Double, gate : (Qubit => Unit)) : Unit {

    }

    function CalculateExpectationValueX(probability : Double) : Double {
        return 2.0 * probability * (1.0 - probability);
    }

    function CalculateExpectationValueY(probability : Double) : Double {

    }

    function CalculateExpectationValueZ(probability : Double) : Double {
        return probability^2 - (1.0 - probability)^2; 
    }

    operation FindExpectedValue(InitialStateOracle : (Qubit => Unit), 
                                MysteryGate : (Qubit => Unit), 
                                ancilla : Qubit, moe : Double) : Double {
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
                if (RunSingleIteration(InitialStateOracle, MysteryGate, ancilla)) {
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

        return out_val;
    }

    function MarginOfError(probability : Double, runs : Double, Z_SCORE : Double) : Double {
        return Z_SCORE * SQRT(probability * (1.0 - probability) / runs);
    }

    operation RunSingleIteration(InitialStateOracle : (Qubit => Unit),
                                 MysteryGate : (Qubit => Unit), ancilla : Qubit) : Bool {
        // given a specific eigenstate and gate we want to identify the expected value of, 
        // run one trial and create either 1 or 0

        // prepare the sample eigenstate
        InitialStateOracle(ancilla);

        // apply the gate that we want to estimate the expected value of
        MysteryGate(ancilla);

        // return true if the output value is one; false if the output value is zero
        let out_val = M(ancilla) == One ? true | false;

        // reset the ancilla so that it can be used immediately after
        Reset(ancilla);

        return out_val;
    }
}
