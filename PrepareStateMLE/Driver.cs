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

namespace PrepareStateMLE
{
    class Driver
    {
        static void Main(string[] args)
        {
            // var FILENAME = "h2_2_sto6g_1.0au.yaml";
            var FILENAME = "h4_sto6g_0.000.yaml";
            // var FILENAME = "h20_nwchem.yaml";

            var STATE = "|G>";

            // create the first hamiltonian from the YAML File
            var hamiltonian = FermionHamiltonian.LoadFromYAML($@"{FILENAME}").First();

            // convert the hamiltonian into it's JW Encoding
            var JWEncoding = JordanWignerEncoding.Create(hamiltonian);

            var data = JWEncoding.QSharpData(STATE);

            using (var qsim = new QuantumSimulator())
            {
                var res = PrepareStateMLE.Run(qsim, data).Result;
                Console.WriteLine($"MLE is {res}");
            }
        }
    }
}