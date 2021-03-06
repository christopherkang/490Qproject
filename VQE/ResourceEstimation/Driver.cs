﻿using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Extensions.Testing;
using Microsoft.Quantum.Chemistry;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using System.IO;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;
using Microsoft.Quantum.Simulation.QCTraceSimulatorRuntime;

namespace ResourceEstimation
{
    class Driver
    {
        static void Main(string[] args)
        {
            #region Parameters of Operation
            // filename of the molecule to be emulated 

            // var FILENAME = "h2_2_sto6g_1.0au.yaml";
            var FILENAME = "h4_sto6g_0.000.yaml";
            // var FILENAME = "h20_nwchem.yaml";

            // use this state provided in the YAML.
            var STATE = "|G>";

            // the margin of error to use when approximating the expected value 
            var MOE = 0.1;

            // precision to iterate over with the state preparation gate
            // the number of trials is directly proportional to this constant's inverse
            // the gate will be applying a transform of the form (2 pi i \phi) where \phi
            // varies by the precision specified below
            var ANGULAR_PRECISION = 0.01;

            Console.WriteLine($"STATE: {STATE} | MOE: {MOE} | PRECISION: {ANGULAR_PRECISION}");

            #endregion

            #region Creating the Hamiltonian and JW Terms

            // create the first hamiltonian from the YAML File
            var hamiltonian = FermionHamiltonian.LoadFromYAML($@"{FILENAME}").First();

            // convert the hamiltonian into it's JW Encoding
            var JWEncoding = JordanWignerEncoding.Create(hamiltonian);

            var data = JWEncoding.QSharpData(STATE);

            // Console.WriteLine("----- Print Hamiltonian");
            // Console.Write(hamiltonian);
            // Console.WriteLine("----- End Print Hamiltonian \n");

            #endregion
            #region Hybrid Quantum/Classical accelerator
            // Feed created state and hamiltonian terms to VQE
            Console.WriteLine("----- Begin VQE Simulation");

            //var N = 10; // number of qubits, calculate from data???
            //var oneReal = (1.0, 0.0);
            //var inputCoeffs = new ComplexPolar[N];
            //for (int i = 0; i < Length(inputCoeffs) - 1; i++)
            // {
            //     inputCoeffs[i] = oneReal;
            // }
            ResourcesEstimator estimator = new ResourcesEstimator();
            Simulate.Run(estimator, data, 1.0, MOE).Wait();
            //Aux.Run(estimator).Wait();
            
            var configCNOT = new QCTraceSimulatorConfiguration();
            configCNOT.useDepthCounter = true;
            configCNOT.gateTimes[PrimitiveOperationsGroups.CNOT] = 1.0;
            configCNOT.gateTimes[PrimitiveOperationsGroups.Measure] = 0.0;
            configCNOT.gateTimes[PrimitiveOperationsGroups.QubitClifford] = 0.0;
            configCNOT.gateTimes[PrimitiveOperationsGroups.R] = 0.0;
            configCNOT.gateTimes[PrimitiveOperationsGroups.T] = 0.0;
            
            var traceSimCNOT = new QCTraceSimulator(configCNOT);
            Simulate.Run(traceSimCNOT, data, 1.0, MOE).Wait();

            double cnotDepth = traceSimCNOT.GetMetric<Simulate>(DepthCounter.Metrics.Depth);

            var configT = new QCTraceSimulatorConfiguration();
            configT.useDepthCounter = true;
            configT.gateTimes[PrimitiveOperationsGroups.CNOT] = 0.0;
            configT.gateTimes[PrimitiveOperationsGroups.Measure] = 0.0;
            configT.gateTimes[PrimitiveOperationsGroups.QubitClifford] = 0.0;
            configT.gateTimes[PrimitiveOperationsGroups.R] = 0.0;
            configT.gateTimes[PrimitiveOperationsGroups.T] = 1.0;
            
            var traceSimT = new QCTraceSimulator(configT);
            Simulate.Run(traceSimT, data, 1.0, MOE).Wait();

            double tDepth = traceSimT.GetMetric<Simulate>(DepthCounter.Metrics.Depth);

            var configClifford = new QCTraceSimulatorConfiguration();
            configClifford.useDepthCounter = true;
            configClifford.gateTimes[PrimitiveOperationsGroups.CNOT] = 0.0;
            configClifford.gateTimes[PrimitiveOperationsGroups.Measure] = 0.0;
            configClifford.gateTimes[PrimitiveOperationsGroups.QubitClifford] = 1.0;
            configClifford.gateTimes[PrimitiveOperationsGroups.R] = 0.0;
            configClifford.gateTimes[PrimitiveOperationsGroups.T] = 0.0;
            
            var traceSimClifford = new QCTraceSimulator(configClifford);
            Simulate.Run(traceSimClifford, data, 1.0, MOE).Wait();

            double cliffordDepth = traceSimClifford.GetMetric<Simulate>(DepthCounter.Metrics.Depth);

            Console.WriteLine(estimator.ToTSV());
            Console.WriteLine($"CNOT depth is {cnotDepth}");
            Console.WriteLine($"T depth is {tDepth}");
            Console.WriteLine($"Clifford depth is {cliffordDepth}");

            #endregion 
            #region Classical update scheme
            // Determine how to update the starting state using classical methods
            #endregion
        }
    }
}