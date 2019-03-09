#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"arbitrary_test\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Intro1/VQE/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":57}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"arbitrary_test\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Intro1/VQE/Operations.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"TrotterStepOracle\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Intro1/VQE/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":67}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":85}}]}}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"TrotterStepOracle\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Intro1/VQE/Operations.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace VQE
{
    public class arbitrary_test : Operation<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, ((QArray<Int64>,QArray<Double>),QArray<Int64>)>, ICallable
    {
        public arbitrary_test(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<((QArray<Int64>,QArray<Double>),QArray<Int64>)>, IApplyData
        {
            public Out(((QArray<Int64>,QArray<Double>),QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "arbitrary_test";
        String ICallable.FullName => "VQE.arbitrary_test";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Microsoft.Quantum.Canon.GeneratorIndex> TrotterStepOracle
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, ((QArray<Int64>,QArray<Double>),QArray<Int64>)> Body => (__in__) =>
        {
            var data = __in__;
#line 10 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = data.Data;
#line 13 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            Message.Apply("WHY WON'T YOU HEAR ME");
#line 16 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            return TrotterStepOracle.Apply(data).Data;
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.TrotterStepOracle = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Microsoft.Quantum.Canon.GeneratorIndex>>(typeof(TrotterStepOracle));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data) => data;
        public override IApplyData __dataOut(((QArray<Int64>,QArray<Double>),QArray<Int64>) data) => new Out(data);
        public static System.Threading.Tasks.Task<((QArray<Int64>,QArray<Double>),QArray<Int64>)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data)
        {
            return __m__.Run<arbitrary_test, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, ((QArray<Int64>,QArray<Double>),QArray<Int64>)>(data);
        }
    }

    public class TrotterStepOracle : Operation<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Microsoft.Quantum.Canon.GeneratorIndex>, ICallable
    {
        public TrotterStepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TrotterStepOracle";
        String ICallable.FullName => "VQE.TrotterStepOracle";
        protected ICallable<QVoid, Microsoft.Quantum.Canon.EvolutionSet> MicrosoftQuantumChemistryJordanWignerJordanWignerFermionEvolutionSet
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JWOptimizedHTerms, Microsoft.Quantum.Canon.GeneratorSystem> MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Microsoft.Quantum.Canon.GeneratorIndex> Body => (__in__) =>
        {
            var qSharpData = __in__;
#line 31 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 34 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var generatorSystem = MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem.Apply(data);
#line 37 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var evolutionGenerator = new Microsoft.Quantum.Canon.EvolutionGenerator((MicrosoftQuantumChemistryJordanWignerJordanWignerFermionEvolutionSet.Apply(QVoid.Instance), generatorSystem));
#line 40 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var (evolutionSet,generator) = evolutionGenerator.Data;
#line 46 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var (nTerms,generatorSystemFunction) = generator.Data;
#line 49 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            var generatorIndex = generatorSystemFunction.Apply<Microsoft.Quantum.Canon.GeneratorIndex>(0L);
#line 52 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            Message.Apply(String.Format("{0}", evolutionSet.Data.Apply<Microsoft.Quantum.Canon.EvolutionUnitary>(generatorIndex).Data));
#line 53 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            Message.Apply(String.Format("{0}", MicrosoftQuantumChemistryJordanWignerJordanWignerFermionEvolutionSet.Apply(QVoid.Instance).Data));
#line 61 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Intro1\\VQE\\Operations.qs"
            return generatorIndex;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumChemistryJordanWignerJordanWignerFermionEvolutionSet = this.Factory.Get<ICallable<QVoid, Microsoft.Quantum.Canon.EvolutionSet>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerFermionEvolutionSet));
            this.MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JWOptimizedHTerms, Microsoft.Quantum.Canon.GeneratorSystem>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerGeneratorSystem));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.GeneratorIndex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.GeneratorIndex> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData)
        {
            return __m__.Run<TrotterStepOracle, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Microsoft.Quantum.Canon.GeneratorIndex>(qSharpData);
        }
    }
}