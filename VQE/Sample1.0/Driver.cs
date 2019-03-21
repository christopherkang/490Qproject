using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Extensions.Testing;
using Microsoft.Quantum.Chemistry;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using Accord.Math.Optimization;
using Microsoft.Quantum.Chemistry.JordanWigner;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Quantum.Simulation.Simulators.QCTraceSimulators;
using Microsoft.Quantum.Simulation.QCTraceSimulatorRuntime;

// This driver runs the Variational Quantum Eigensolver
// The user will be prompted to type "QE" or "VQE"
// QE is a naive eigensolver which uses the ground state
// configuration provided by the Broombridge file
// VQE is a variational eigensolver which uses the Nelder-Mead
// method to minimize the energy of the molecule under investigation.
// If VQE is chosen, the user is prompted to choose whether
// or not to use the ground state configuration from Broombridge
// or to start from the zero vector as initial conditions for the
// Nelder-Mead algorithm. 

// The purpose of this program is to extend the suite of algorithms
// implemented in Q# and the QDK to enable quantum chemists to use VQE
// as a benchmark for calculating the ground state configuration of 
// molecules defined in Broombridge format.

namespace VQE
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Prompts user whether to run naive eigensolver (QE)
            // or variational eigensolver (VQE)
            // QE will use the ground state provided in Broombridge file (FILENAME, see below)
            // VQE will give the user the option to use the ground state from Broombridge
            // as initial conditions, if not the initial conditions are all zero
            Console.Write("Run QE or VQE? ");
            String runString = Console.ReadLine();

            #region Parameters of Operation
            // filename of the molecule to be emulated 

            // var FILENAME = "h2_2_sto6g_1.0au.yaml";
            // var FILENAME = "h4_sto6g_0.000.yaml";
            var FILENAME = "h20_nwchem.yaml";

            // use this state provided in the YAML.
            var STATE = "|G>";

            // the margin of error to use when approximating the expected value 
            var MOE = 0.1;

            // precision to iterate over with the state preparation gate
            // the number of trials is directly proportional to this constant's inverse
            // the gate will be applying a transform of the form (2 pi i \phi) where \phi
            // varies by the precision specified below
            var ANGULAR_PRECISION = 0.01;
            
            // Communicates to the user what state, margin of error, and precision are being used
            Console.WriteLine($"STATE: {STATE} | MOE: {MOE} | PRECISION: {ANGULAR_PRECISION}");

            #endregion

            #region Creating the Hamiltonian and JW Terms

            // create the first hamiltonian from the YAML File
            var hamiltonian = FermionHamiltonian.LoadFromYAML($@"{FILENAME}").First();

            // convert the hamiltonian into it's JW Encoding
            var JWEncoding = JordanWignerEncoding.Create(hamiltonian);

            // JW encoding data to be passed to Q#
            var data = JWEncoding.QSharpData(STATE);

            #endregion
            #region Hybrid Quantum/Classical accelerator

            // Communicate to the user the choice of eigensolver
            if (runString.Equals("VQE")) {
                Console.WriteLine("----- Begin VQE Simulation");
            } else {
                Console.WriteLine("----- Begin QE Simulation");
            }
            
            using (var qsim = new QuantumSimulator())
            {
                // Block to run VQE
                if (runString.Equals("VQE")) {
                    string useGroundState;
                    Console.Write("Use ground state? (yes or no): ");
                    useGroundState = Console.ReadLine();

                    // extract parameters for use below
                    var statePrepData = data.Item3; 
                    var N = statePrepData.Length;
                    
                    // method to convert optimized parameters, i.e. the
                    // coefficients of the creation/annihilation operators
                    // to JordanWignerInputStates that can be run in the 
                    // simulation defined in Q#
                    double convertDoubleArrToJWInputStateArr (double[] x) {
                        var JWInputStateArr = new QArray<JordanWignerInputState>();
                        for (int i = 0; i < N; i++) {
                            var currJWInputState = statePrepData[i];
                            var positions = currJWInputState.Item2; // registers to apply coefficients
                            JWInputStateArr.Add(new JordanWignerInputState(((x[i], 0.0), positions)));
                        }
                        return Simulate_Variational.Run(qsim, data, 1.0, MOE, JWInputStateArr).Result;
                    }  

                    // wrapper function which feeds parameters to be optimized to minimize
                    // the output of the simulation of the molecule defined in FILENAME
                    Func<double[], double> Simulate_Wrapper = (double[] x) => convertDoubleArrToJWInputStateArr(x);

                    // create new Nelder-Mead solver on the simulation of the molecule
                    var solver = new NelderMead((int) N, Simulate_Wrapper);

                    // create initial condition vector
                    var initialConds = new double[N];
                    for (int i = 0; i < N; i++) {
                        if (useGroundState.Equals("yes")) {
                            var currJWInputState = statePrepData[i];
                            var groundStateGuess = currJWInputState.Item1;
                            initialConds[i] = groundStateGuess.Item1;
                        } else {
                            initialConds[i] = 0.0;
                        }
                    }

                    // Now, we can minimize it with:
                    bool success = solver.Minimize(initialConds);

                    // And get the solution vector using
                    double[] solution = solver.Solution; 

                    // The minimum at this location would be:
                    double minimum = solver.Value;

                    // Communicate VQE results to the user
                    // success indicates wheter the solution converged
                    // solution is the vector of coefficients for the creation/annihilation
                    // operators defined in positions (defined in convertDoubleArrToJWInputStateArr)
                    // minimum is the value of the minimum energy found by VQE
                    Console.WriteLine($"Solution converged: {success}");
                    Console.WriteLine("The solution is: " + String.Join(" ", solution));
                    Console.WriteLine($"The minimum is: {minimum}");
                } else { // Run QE
                    Console.WriteLine(Simulate.Run(qsim, data, 1.0, MOE).Result);
                }
            }
            #endregion 
            #region Classical update scheme
            // Determine how to update the starting state using classical methods
            #endregion
        }
    }
}