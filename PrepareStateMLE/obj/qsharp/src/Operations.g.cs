#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PrepareStateMLE\",\"Name\":\"create_generator\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":66}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorSystem\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":86}}]}}]},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PrepareStateMLE\",\"Name\":\"create_generator\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PrepareStateMLE\",\"Name\":\"PrepareStateMLE\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":59}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PrepareStateMLE\",\"Name\":\"PrepareStateMLE\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace PrepareStateMLE
{
    public class create_generator : Operation<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)>, ICallable
    {
        public create_generator(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Microsoft.Quantum.Canon.GeneratorSystem,Int64)>, IApplyData
        {
            public Out((Microsoft.Quantum.Canon.GeneratorSystem,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1?.Data.Item2)?.Qubits;
        }

        String ICallable.Name => "create_generator";
        String ICallable.FullName => "PrepareStateMLE.create_generator";
        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JWOptimizedHTerms, Microsoft.Quantum.Canon.GeneratorSystem> MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)> Body => (__in__) =>
        {
            var qSharpData = __in__;
#line 12 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 17 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var generatorSystem = MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem.Apply(data);
#line 19 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            return (generatorSystem, nSpinOrbitals);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JWOptimizedHTerms, Microsoft.Quantum.Canon.GeneratorSystem>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerGeneratorSystem));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data) => data;
        public override IApplyData __dataOut((Microsoft.Quantum.Canon.GeneratorSystem,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Microsoft.Quantum.Canon.GeneratorSystem,Int64)> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData qSharpData)
        {
            return __m__.Run<create_generator, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)>(qSharpData);
        }
    }

    public class PrepareStateMLE : Operation<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Double>, ICallable
    {
        public PrepareStateMLE(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareStateMLE";
        String ICallable.FullName => "PrepareStateMLE.PrepareStateMLE";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), Double> PrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)> create_generator
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Double> Body => (__in__) =>
        {
            var data = __in__;
#line 23 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = data.Data;
#line 24 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var (ham_terms,nOrbitals) = create_generator.Apply(data);
#line 26 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var n_trials = 100L;
#line 27 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var n_trials_d = 100D;
#line 28 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            var total = 0D;
#line hidden
            {
#line 29 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                var ancilla = Allocate.Apply(nOrbitals);
#line 30 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                foreach (var i in new Range(1L, n_trials))
#line hidden
                {
#line 32 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                    var times = PrepareTrialState.Apply((statePrepData?.Copy(), ancilla?.Copy()));
#line 33 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                    Message.Apply(String.Format("times is {0}", times));
#line 34 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                    total = (total + times);
#line 35 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                    if ((times == 0D))
                    {
#line 37 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                        n_trials_d = (n_trials_d - 1D);
                    }

#line 39 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                    ResetAll.Apply(ancilla?.Copy());
                }

#line hidden
                Release.Apply(ancilla);
            }

#line 42 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            if ((n_trials_d == 0D))
            {
#line 44 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
                return 1D;
            }

#line 46 "/Users/Julian/polybox/490Qproject/PrepareStateMLE/Operations.qs"
            return (n_trials_d / total);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.PrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), Double>>(typeof(PrepareTrialState));
            this.create_generator = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)>>(typeof(create_generator));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data)
        {
            return __m__.Run<PrepareStateMLE, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, Double>(data);
        }
    }
}