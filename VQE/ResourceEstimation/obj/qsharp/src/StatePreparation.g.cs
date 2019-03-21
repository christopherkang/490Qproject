#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialState\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"superposition\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":67}}]}}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Null\"}}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialState\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateSingleSiteOccupation\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubitIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":78}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Simple state preparation of trial state by occupying\",\" spin-orbitals\",\"\",\" # Input\",\" ## qubitIndices\",\" Indices of qubits to be occupied by electrons.\",\" ## qubits\",\" Qubits of Hamiltonian.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateSingleSiteOccupation\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":40,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateSingleSiteOccupation\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateSingleSiteOccupation\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateSingleSiteOccupation\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"_PrepareTrialStateSingleSiteOccupation_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":49}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubitIndices\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"_PrepareTrialStateSingleSiteOccupation_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":49}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateCoupledCluster\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initialStatePreparation\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"excitations\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":103},\"Item2\":{\"Line\":1,\"Column\":125}}]}}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":100}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":129},\"Item2\":{\"Line\":1,\"Column\":135}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Null\"}}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Coupled-cluster state preparation of trial state by adding excitations\",\" to initial trial state.\",\"\",\" # Input\",\" ## initialStatePreparation\",\" Unitary to prepare initial trial state.\",\" ## excitations\",\" Excitations of initial trial state represented by\",\" the amplitude of the excitation and the qubit indices\",\" the excitation acts on.\",\" ## qubits\",\" Qubits of Hamiltonian.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ResourceEstimation\",\"Name\":\"PrepareTrialStateCoupledCluster\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
#line hidden
namespace ResourceEstimation
{
    public class PrepareTrialState : Operation<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>, ICallable
    {
        public PrepareTrialState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "PrepareTrialState";
        String ICallable.FullName => "ResourceEstimation.PrepareTrialState";
        protected IUnitary MicrosoftQuantumCanonNoOp
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> PrepareTrialStateCoupledCluster
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,QArray<Qubit>)> PrepareTrialStateSingleSiteOccupation
        {
            get;
            set;
        }

        public override Func<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (superposition,qubits) = __in__;
#line 17 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            if ((superposition.Length == 0L))
            {
            }
            else if ((superposition.Length == 1L))
            {
#line 21 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                var (complex,qubitIndices) = superposition[0L].Data;
#line 22 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                PrepareTrialStateSingleSiteOccupation.Apply((qubitIndices?.Copy(), qubits?.Copy()));
            }
            else
            {
#line 25 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                var times = PrepareTrialStateCoupledCluster.Apply((MicrosoftQuantumCanonNoOp, superposition?.Copy(), qubits?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonNoOp = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.NoOp<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.PrepareTrialStateCoupledCluster = this.Factory.Get<ICallable<(ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(PrepareTrialStateCoupledCluster));
            this.PrepareTrialStateSingleSiteOccupation = this.Factory.Get<IUnitary<(QArray<Int64>,QArray<Qubit>)>>(typeof(PrepareTrialStateSingleSiteOccupation));
        }

        public override IApplyData __dataIn((QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState> superposition, QArray<Qubit> qubits)
        {
            return __m__.Run<PrepareTrialState, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>((superposition, qubits));
        }
    }

    public class PrepareTrialStateSingleSiteOccupation : Unitary<(QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public PrepareTrialStateSingleSiteOccupation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "PrepareTrialStateSingleSiteOccupation";
        String ICallable.FullName => "ResourceEstimation.PrepareTrialStateSingleSiteOccupation";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (qubitIndices,qubits) = __in__;
#line 42 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((qubitIndices?.Copy(), qubits?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (qubitIndices,qubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((qubitIndices?.Copy(), qubits?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qubitIndices,qubits)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((qubitIndices?.Copy(), qubits?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qubitIndices,qubits)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((qubitIndices?.Copy(), qubits?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> qubitIndices, QArray<Qubit> qubits)
        {
            return __m__.Run<PrepareTrialStateSingleSiteOccupation, (QArray<Int64>,QArray<Qubit>), QVoid>((qubitIndices, qubits));
        }
    }

    public class _PrepareTrialStateSingleSiteOccupation_ : Function<QArray<Int64>, IUnitary>, ICallable
    {
        public _PrepareTrialStateSingleSiteOccupation_(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_PrepareTrialStateSingleSiteOccupation_";
        String ICallable.FullName => "ResourceEstimation._PrepareTrialStateSingleSiteOccupation_";
        protected IUnitary<(QArray<Int64>,QArray<Qubit>)> PrepareTrialStateSingleSiteOccupation
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, IUnitary> Body => (__in__) =>
        {
            var qubitIndices = __in__;
#line 53 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            return PrepareTrialStateSingleSiteOccupation.Partial(new Func<QArray<Qubit>, (QArray<Int64>,QArray<Qubit>)>((__arg1__) => (qubitIndices?.Copy(), __arg1__)));
        }

        ;
        public override void Init()
        {
            this.PrepareTrialStateSingleSiteOccupation = this.Factory.Get<IUnitary<(QArray<Int64>,QArray<Qubit>)>>(typeof(PrepareTrialStateSingleSiteOccupation));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> qubitIndices)
        {
            return __m__.Run<_PrepareTrialStateSingleSiteOccupation_, QArray<Int64>, IUnitary>(qubitIndices);
        }
    }

    public class PrepareTrialStateCoupledCluster : Operation<(ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>, ICallable
    {
        public PrepareTrialStateCoupledCluster(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareTrialStateCoupledCluster";
        String ICallable.FullName => "ResourceEstimation.PrepareTrialStateCoupledCluster";
        protected ICallable<Microsoft.Quantum.Canon.ComplexPolar, Double> MicrosoftQuantumCanonAbsComplexPolar
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.ComplexPolar, Double> MicrosoftQuantumCanonArgComplexPolar
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar> MicrosoftQuantumCanonComplexToComplexPolar
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumCanonLg
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonLookupFunction
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMap
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), IUnitary> MicrosoftQuantumCanonMultiplexerBruteForceFromGenerator
        {
            get;
            set;
        }

        protected ICallable<QArray<Microsoft.Quantum.Canon.ComplexPolar>, IUnitary> MicrosoftQuantumCanonStatePreparationComplexCoefficients
        {
            get;
            set;
        }

        protected ICallable<QArray<Double>, IUnitary> MicrosoftQuantumCanonStatePreparationPositiveCoefficients
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, IUnitary> _PrepareTrialStateSingleSiteOccupation_
        {
            get;
            set;
        }

        public override Func<(ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (initialStatePreparation,excitations,qubits) = __in__;
#line 72 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            var nExcitations = excitations.Length;
#line 75 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            var coefficientsSqrtAbs = new QArray<Double>(nExcitations);
#line 76 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            var coefficientsNewComplexPolar = new QArray<Microsoft.Quantum.Canon.ComplexPolar>(nExcitations);
#line 77 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            var applyFlips = new QArray<QArray<Int64>>(nExcitations);
#line 79 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            foreach (var idx in new Range(0L, (nExcitations - 1L)))
#line hidden
            {
#line 80 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                var (x,excitation) = excitations[idx].Data;
#line 81 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                coefficientsSqrtAbs[idx] = MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumCanonAbsComplexPolar.Apply(MicrosoftQuantumCanonComplexToComplexPolar.Apply(new Microsoft.Quantum.Extensions.Math.Complex(x))));
#line 82 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                coefficientsNewComplexPolar[idx] = new Microsoft.Quantum.Canon.ComplexPolar((coefficientsSqrtAbs[idx], MicrosoftQuantumCanonArgComplexPolar.Apply(MicrosoftQuantumCanonComplexToComplexPolar.Apply(new Microsoft.Quantum.Extensions.Math.Complex(x)))));
#line 83 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                applyFlips[idx] = excitation?.Copy();
            }

#line 86 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            var nBitsIndices = MicrosoftQuantumExtensionsMathCeiling.Apply(MicrosoftQuantumCanonLg.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(nExcitations)));
#line 87 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
            while (true)
            {
#line 88 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                var success = false;
#line hidden
                {
#line 90 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                    var auxillary = Allocate.Apply((nBitsIndices + 1L));
#line hidden
                    {
#line 91 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        var flag = Allocate.Apply(1L);
#line 92 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        var multiplexer = MicrosoftQuantumCanonMultiplexerBruteForceFromGenerator.Apply((nExcitations, MicrosoftQuantumCanonLookupFunction.Apply<ICallable>(MicrosoftQuantumCanonMap.Apply<QArray<IUnitary>>((_PrepareTrialStateSingleSiteOccupation_, applyFlips?.Copy())))));
#line 93 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        MicrosoftQuantumCanonStatePreparationComplexCoefficients.Apply(coefficientsNewComplexPolar).Apply(new Microsoft.Quantum.Canon.BigEndian(auxillary?.Copy()));
#line 94 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        multiplexer.Apply((new Microsoft.Quantum.Canon.BigEndian(auxillary?.Copy()), qubits?.Copy()));
#line 95 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        MicrosoftQuantumCanonStatePreparationPositiveCoefficients.Apply(coefficientsSqrtAbs).Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(auxillary?.Copy()));
#line 96 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumPrimitiveX)).Apply((auxillary?.Copy(), flag[0L]));
#line 100 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        AssertProb.Apply((new QArray<Pauli>()
                        {Pauli.PauliZ}, flag?.Copy(), Result.One, 0.137551581843191D, "MLE for H4", 1E-05D));
#line 102 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        var outcome = Measure.Apply((new QArray<Pauli>()
                        {Pauli.PauliZ}, flag?.Copy()));
#line 103 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/StatePreparation.qs"
                        success = (outcome == Result.One);
#line hidden
                        Release.Apply(flag);
                    }

#line hidden
                    Release.Apply(auxillary);
                }

                if (success)
                {
                    break;
                }
                else
                {
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAbsComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.ComplexPolar, Double>>(typeof(Microsoft.Quantum.Canon.AbsComplexPolar));
            this.MicrosoftQuantumCanonArgComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.ComplexPolar, Double>>(typeof(Microsoft.Quantum.Canon.ArgComplexPolar));
            this.MicrosoftQuantumCanonComplexToComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(Microsoft.Quantum.Canon.ComplexToComplexPolar));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonLg = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Canon.Lg));
            this.MicrosoftQuantumCanonLookupFunction = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.LookupFunction<>));
            this.MicrosoftQuantumCanonMap = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Map<,>));
            this.MicrosoftQuantumCanonMultiplexerBruteForceFromGenerator = this.Factory.Get<ICallable<(Int64,ICallable), IUnitary>>(typeof(Microsoft.Quantum.Canon.MultiplexerBruteForceFromGenerator));
            this.MicrosoftQuantumCanonStatePreparationComplexCoefficients = this.Factory.Get<ICallable<QArray<Microsoft.Quantum.Canon.ComplexPolar>, IUnitary>>(typeof(Microsoft.Quantum.Canon.StatePreparationComplexCoefficients));
            this.MicrosoftQuantumCanonStatePreparationPositiveCoefficients = this.Factory.Get<ICallable<QArray<Double>, IUnitary>>(typeof(Microsoft.Quantum.Canon.StatePreparationPositiveCoefficients));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this._PrepareTrialStateSingleSiteOccupation_ = this.Factory.Get<ICallable<QArray<Int64>, IUnitary>>(typeof(_PrepareTrialStateSingleSiteOccupation_));
        }

        public override IApplyData __dataIn((ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable initialStatePreparation, QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState> excitations, QArray<Qubit> qubits)
        {
            return __m__.Run<PrepareTrialStateCoupledCluster, (ICallable,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>((initialStatePreparation, excitations, qubits));
        }
    }
}