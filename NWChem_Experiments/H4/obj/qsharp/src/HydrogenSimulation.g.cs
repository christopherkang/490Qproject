#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Chemistry.Samples.Hydrogen\",\"Name\":\"GetEnergyByTrotterization\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/NWChem_Experiments/H4/HydrogenSimulation.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":75}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nBitsPrecision\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":91}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"trotterStepSize\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":114}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"trotterOrder\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":125},\"Item2\":{\"Line\":1,\"Column\":137}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Chemistry.Samples.Hydrogen\",\"Name\":\"GetEnergyByTrotterization\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/NWChem_Experiments/H4/HydrogenSimulation.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Chemistry.Samples.Hydrogen\",\"Name\":\"GetEnergyByQubitization\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/NWChem_Experiments/H4/HydrogenSimulation.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":73}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nBitsPrecision\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":75},\"Item2\":{\"Line\":1,\"Column\":89}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Chemistry.Samples.Hydrogen\",\"Name\":\"GetEnergyByQubitization\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/NWChem_Experiments/H4/HydrogenSimulation.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Chemistry.Samples.Hydrogen
{
    public class GetEnergyByTrotterization : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64), (Double,Double)>, ICallable
    {
        public GetEnergyByTrotterization(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Double,Double)>, IApplyData
        {
            public Out((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetEnergyByTrotterization";
        String ICallable.FullName => "Microsoft.Quantum.Chemistry.Samples.Hydrogen.GetEnergyByTrotterization";
        protected ICallable<(Int64,ICallable,IUnitary,ICallable), Double> MicrosoftQuantumCanonEstimateEnergy
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))> MicrosoftQuantumChemistryJordanWignerTrotterStepOracle
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64), (Double,Double)> Body => (__in__) =>
        {
            var (qSharpData,nBitsPrecision,trotterStepSize,trotterOrder) = __in__;
#line 36 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = qSharpData.Data;
#line 40 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var (nQubits,(rescaleFactor,oracle)) = MicrosoftQuantumChemistryJordanWignerTrotterStepOracle.Apply((qSharpData, trotterStepSize, trotterOrder));
#line 44 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var statePrep = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((__arg1__) => (statePrepData?.Copy(), __arg1__)));
#line 48 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var phaseEstAlgorithm = MicrosoftQuantumCanonRobustPhaseEstimation.Partial(new Func<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), (Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>)>((__arg2__) => (nBitsPrecision, __arg2__.Item1, __arg2__.Item2)));
#line 51 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var estPhase = MicrosoftQuantumCanonEstimateEnergy.Apply((nQubits, statePrep, oracle, phaseEstAlgorithm));
#line 56 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var estEnergy = ((estPhase * rescaleFactor) + energyOffset);
#line 59 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            return (estPhase, estEnergy);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonEstimateEnergy = this.Factory.Get<ICallable<(Int64,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.EstimateEnergy));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumChemistryJordanWignerTrotterStepOracle = this.Factory.Get<ICallable<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), (Int64,(Double,IUnitary))>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.TrotterStepOracle));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64) data) => new In(data);
        public override IApplyData __dataOut((Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Double,Double)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData, Int64 nBitsPrecision, Double trotterStepSize, Int64 trotterOrder)
        {
            return __m__.Run<GetEnergyByTrotterization, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64,Double,Int64), (Double,Double)>((qSharpData, nBitsPrecision, trotterStepSize, trotterOrder));
        }
    }

    public class GetEnergyByQubitization : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)>, ICallable
    {
        public GetEnergyByQubitization(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Double,Double)>, IApplyData
        {
            public Out((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetEnergyByQubitization";
        String ICallable.FullName => "Microsoft.Quantum.Chemistry.Samples.Hydrogen.GetEnergyByQubitization";
        protected ICallable<(Int64,ICallable,IUnitary,ICallable), Double> MicrosoftQuantumCanonEstimateEnergy
        {
            get;
            set;
        }

        protected ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double> MicrosoftQuantumCanonRobustPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Int64,(Double,IUnitary))> MicrosoftQuantumChemistryJordanWignerQubitizationOracle
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)> Body => (__in__) =>
        {
            var (qSharpData,nBitsPrecision) = __in__;
#line 75 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = qSharpData.Data;
#line 79 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var (nQubits,(oneNorm,oracle)) = MicrosoftQuantumChemistryJordanWignerQubitizationOracle.Apply(qSharpData);
#line 83 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var statePrep = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((__arg1__) => (statePrepData?.Copy(), __arg1__)));
#line 87 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var phaseEstAlgorithm = MicrosoftQuantumCanonRobustPhaseEstimation.Partial(new Func<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), (Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>)>((__arg2__) => (nBitsPrecision, __arg2__.Item1, __arg2__.Item2)));
#line 90 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var estPhase = MicrosoftQuantumCanonEstimateEnergy.Apply((nQubits, statePrep, oracle, phaseEstAlgorithm));
#line 98 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            var estEnergy = ((MicrosoftQuantumExtensionsMathSin.Apply(estPhase) * oneNorm) + energyOffset);
#line 101 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\NWChem_Experiments\\H4\\HydrogenSimulation.qs"
            return (estPhase, estEnergy);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonEstimateEnergy = this.Factory.Get<ICallable<(Int64,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.EstimateEnergy));
            this.MicrosoftQuantumCanonRobustPhaseEstimation = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.RobustPhaseEstimation));
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumChemistryJordanWignerQubitizationOracle = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Int64,(Double,IUnitary))>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.QubitizationOracle));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64) data) => new In(data);
        public override IApplyData __dataOut((Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Double,Double)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData, Int64 nBitsPrecision)
        {
            return __m__.Run<GetEnergyByQubitization, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Int64), (Double,Double)>((qSharpData, nBitsPrecision));
        }
    }
}