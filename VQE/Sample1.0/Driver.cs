using System;

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

namespace VQE
{
    class Driver
    {
        static void Main(string[] args)
        {
            #region Parameters of Operation
            // filename of the molecule to be emulated 

            var FILENAME = "h2_2_sto6g_1.0au.yaml";
            // var FILENAME = "h4_sto6g_0.000.yaml";
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

            #endregion
            #region Hybrid Quantum/Classical accelerator
            // Feed created state and hamiltonian terms to VQE
            Console.WriteLine("----- Begin VQE Simulation");
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine(Simulate.Run(qsim, data, 1.0, MOE).Result);
            }
            #endregion 
            #region Classical update scheme
            // Determine how to update the starting state using classical methods
            #endregion
        }
    }
}