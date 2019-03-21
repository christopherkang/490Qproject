#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWZTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generatorIndex\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":57}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWZTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWZZTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generatorIndex\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":58}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWZZTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWPQTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"term\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":48}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"extraParityQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJWPQTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitPQandPQQRTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generatorIndex\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":63}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitPQandPQQRTerm_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJW0123Term_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generatorIndex\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":60}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"_SplitJW0123Term_\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"CreatePauliSet\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":208,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generatorIndex\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":58}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorIndex\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"Int\"}]]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MultiUnitary\",\"Name\":\"CreatePauliSet\"},\"SourceFile\":\"/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs\",\"Position\":{\"Item1\":208,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace MultiUnitary
{
    public class _SplitJWZTerm_ : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public _SplitJWZTerm_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_SplitJWZTerm_";
        String ICallable.FullName => "MultiUnitary._SplitJWZTerm_";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (generatorIndex,qubits) = __in__;
#line 14 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,coeff),idxFermions) = generatorIndex.Data;
#line 17 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var total_gates = new QArray<Pauli>(qubits.Length);
#line 20 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            total_gates[idxFermions[0L]] = Pauli.PauliZ;
#line 22 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            return new QArray<(IUnitary,QArray<Pauli>,Int64)>()
            {(MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (total_gates?.Copy(), __arg1__))), total_gates?.Copy(), -(1L))};
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex generatorIndex, QArray<Qubit> qubits)
        {
            return __m__.Run<_SplitJWZTerm_, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((generatorIndex, qubits));
        }
    }

    public class _SplitJWZZTerm_ : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public _SplitJWZZTerm_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_SplitJWZZTerm_";
        String ICallable.FullName => "MultiUnitary._SplitJWZZTerm_";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (generatorIndex,qubits) = __in__;
#line 26 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,coeff),idxFermions) = generatorIndex.Data;
#line 29 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var total_gates = new QArray<Pauli>(qubits.Length);
#line 32 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            total_gates[idxFermions[0L]] = Pauli.PauliZ;
#line 33 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            total_gates[idxFermions[1L]] = Pauli.PauliZ;
#line 35 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            return new QArray<(IUnitary,QArray<Pauli>,Int64)>()
            {(MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (total_gates?.Copy(), __arg1__))), total_gates?.Copy(), 1L)};
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex generatorIndex, QArray<Qubit> qubits)
        {
            return __m__.Run<_SplitJWZZTerm_, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((generatorIndex, qubits));
        }
    }

    public class _SplitJWPQTerm_ : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public _SplitJWPQTerm_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "_SplitJWPQTerm_";
        String ICallable.FullName => "MultiUnitary._SplitJWPQTerm_";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (term,extraParityQubits,qubits) = __in__;
#line 39 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,coeff),idxFermions) = term.Data;
#line 42 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var out_hold = new QArray<(IUnitary,QArray<Pauli>,Int64)>(0L);
#line 45 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsPQ = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((idxFermions?.Slice(new Range(0L, 1L)), qubits?.Copy()));
#line 48 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsJW = qubits?.Slice(new Range((idxFermions[0L] + 1L), (idxFermions[1L] - 1L)));
#line 51 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ops = new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliY));
#line 54 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            foreach (var idxOp in new Range(0L, (ops.Length - 1L)))
#line hidden
            {
#line 55 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                var total_gates = new QArray<Pauli>((qubits.Length + extraParityQubits.Length));
#line 60 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                total_gates[idxFermions[0L]] = ops[idxOp][0L];
#line 61 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                total_gates[idxFermions[1L]] = ops[idxOp][1L];
#line 64 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                foreach (var qubit_index in new Range((idxFermions[0L] + 1L), (idxFermions[1L] - 1L)))
#line hidden
                {
#line 65 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    total_gates[qubit_index] = Pauli.PauliZ;
                }

#line 69 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                foreach (var qubit_index in new Range(qubits.Length, (total_gates.Length - 1L)))
#line hidden
                {
#line 70 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    total_gates[qubit_index] = Pauli.PauliZ;
                }

#line 73 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                out_hold = (out_hold + new QArray<(IUnitary,QArray<Pauli>,Int64)>()
                {(MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (total_gates?.Copy(), __arg1__))), total_gates?.Copy(), 1L)});
            }

#line 75 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            return out_hold;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex term, QArray<Qubit> extraParityQubits, QArray<Qubit> qubits)
        {
            return __m__.Run<_SplitJWPQTerm_, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((term, extraParityQubits, qubits));
        }
    }

    public class _SplitPQandPQQRTerm_ : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public _SplitPQandPQQRTerm_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_SplitPQandPQQRTerm_";
        String ICallable.FullName => "MultiUnitary._SplitPQandPQQRTerm_";
        protected IUnitary<(IUnitary,QArray<Int64>,QArray<Qubit>)> MicrosoftQuantumCanonApplyToSubregisterCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected ICallable<Range, QArray<Int64>> MicrosoftQuantumCanonIntArrayFromRange
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> _SplitJWPQTerm_
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (generatorIndex,qubits) = __in__;
#line 79 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,coeff),idxFermions) = generatorIndex.Data;
#line 81 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitQidx = idxFermions[1L];
#line 89 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            if ((idxFermions.Length == 2L))
            {
#line 90 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                var termPR0 = new Microsoft.Quantum.Canon.GeneratorIndex(((idxTermType?.Copy(), new QArray<Double>()
                {1D}), idxFermions?.Copy()));
#line 91 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return _SplitJWPQTerm_.Apply((termPR0, new QArray<Qubit>(0L), qubits?.Copy()));
            }
            else
            {
#line 94 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                if (((idxFermions[0L] < qubitQidx) && (qubitQidx < idxFermions[3L])))
                {
#line 95 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    var termPR1 = new Microsoft.Quantum.Canon.GeneratorIndex(((idxTermType?.Copy(), new QArray<Double>()
                    {1D}), new QArray<Int64>(idxFermions[0L], (idxFermions[3L] - 1L))));
#line 96 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    var to_process = _SplitJWPQTerm_.Apply((termPR1, new QArray<Qubit>(0L), MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
                    {qubitQidx}, qubits?.Copy()))));
#line 99 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    foreach (var gate_set in new Range(0L, (to_process.Length - 1L)))
#line hidden
                    {
#line 102 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var (given_gate,given_paulis,value) = to_process[gate_set];
#line 110 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var new_oracle = MicrosoftQuantumCanonApplyToSubregisterCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Int64>,QArray<Qubit>)>((__arg1__) => (given_gate, MicrosoftQuantumCanonExclude.Apply<QArray<Int64>>((new QArray<Int64>()
                        {qubitQidx}, MicrosoftQuantumCanonIntArrayFromRange.Apply(new Range(0L, (qubits.Length - 1L))))), __arg1__)));
#line 113 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var new_paulis = ((given_paulis?.Slice(new Range(0L, (qubitQidx - 1L))) + new QArray<Pauli>()
                        {Pauli.PauliI}) + given_paulis?.Slice(new Range(qubitQidx, (given_paulis.Length - 1L))));
#line 114 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        to_process[gate_set] = (new_oracle, new_paulis?.Copy(), 1L);
                    }

#line 116 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    return to_process;
                }
                else
                {
#line 119 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    var termPR1 = new Microsoft.Quantum.Canon.GeneratorIndex(((idxTermType?.Copy(), new QArray<Double>()
                    {1D}), new QArray<Int64>(0L, (idxFermions[3L] - idxFermions[0L]))));
#line 120 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    var to_process = _SplitJWPQTerm_.Apply((termPR1, new QArray<Qubit>()
                    {qubits[qubitQidx]}, qubits?.Slice(new Range(idxFermions[0L], idxFermions[3L]))));
#line 121 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    foreach (var gate_set in new Range(0L, (to_process.Length - 1L)))
#line hidden
                    {
#line 122 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var (given_gate,given_paulis,value) = to_process[gate_set];
#line 125 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var new_oracle = MicrosoftQuantumCanonApplyToSubregisterCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Int64>,QArray<Qubit>)>((__arg2__) => (given_gate, (MicrosoftQuantumCanonIntArrayFromRange.Apply(new Range(idxFermions[0L], idxFermions[3L])) + new QArray<Int64>()
                        {qubitQidx}), __arg2__)));
#line 128 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var new_paulis = new QArray<Pauli>(qubits.Length);
#line 131 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        new_paulis[qubitQidx] = Pauli.PauliZ;
#line 134 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        var counter = 0L;
#line 135 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        foreach (var pauli_index in new Range(idxFermions[0L], idxFermions[3L]))
#line hidden
                        {
#line 136 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                            new_paulis[pauli_index] = given_paulis[counter];
#line 137 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                            counter = (counter + 1L);
                        }

#line 140 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        to_process[gate_set] = (new_oracle, new_paulis?.Copy(), 1L);
                    }

#line 142 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    return to_process;
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToSubregisterCA = this.Factory.Get<IUnitary<(IUnitary,QArray<Int64>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregisterCA));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumCanonIntArrayFromRange = this.Factory.Get<ICallable<Range, QArray<Int64>>>(typeof(Microsoft.Quantum.Canon.IntArrayFromRange));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this._SplitJWPQTerm_ = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(_SplitJWPQTerm_));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex generatorIndex, QArray<Qubit> qubits)
        {
            return __m__.Run<_SplitPQandPQQRTerm_, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((generatorIndex, qubits));
        }
    }

    public class _SplitJW0123Term_ : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public _SplitJW0123Term_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_SplitJW0123Term_";
        String ICallable.FullName => "MultiUnitary._SplitJW0123Term_";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        protected ICallable<Double, Boolean> MicrosoftQuantumChemistryIsNotZero
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (generatorIndex,qubits) = __in__;
#line 148 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,v0123),idxFermions) = generatorIndex.Data;
#line 152 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsPQ = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((idxFermions?.Slice(new Range(0L, 1L)), qubits?.Copy()));
#line 155 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsRS = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((idxFermions?.Slice(new Range(2L, 3L)), qubits?.Copy()));
#line 158 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsPQJW = qubits?.Slice(new Range((idxFermions[0L] + 1L), (idxFermions[1L] - 1L)));
#line 161 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var qubitsRSJW = qubits?.Slice(new Range((idxFermions[2L] + 1L), (idxFermions[3L] - 1L)));
#line 164 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ops = new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX, Pauli.PauliX, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX, Pauli.PauliY, Pauli.PauliY), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliY, Pauli.PauliX, Pauli.PauliY), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliX, Pauli.PauliX, Pauli.PauliY), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliY, Pauli.PauliY, Pauli.PauliY), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliY, Pauli.PauliX, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliX, Pauli.PauliY, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliY, Pauli.PauliY, Pauli.PauliX));
#line 173 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var out_hold = new QArray<(IUnitary,QArray<Pauli>,Int64)>(0L);
#line 176 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            foreach (var idxOp in new Range(0L, (ops.Length - 1L)))
#line hidden
            {
#line 177 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                var total_gates = new QArray<Pauli>(qubits.Length);
#line 179 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                var value = 1L;
#line 181 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                if (((idxOp == 0L) || (idxOp == 5L)))
                {
#line 182 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    value = -(1L);
                }

#line 185 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                if (MicrosoftQuantumChemistryIsNotZero.Apply(v0123[(idxOp % 4L)]))
                {
#line 187 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    foreach (var op_index in new Range(0L, (ops[idxOp].Length - 1L)))
#line hidden
                    {
#line 189 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        total_gates[idxFermions[op_index]] = ops[idxOp][op_index];
                    }

#line 193 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    foreach (var qubit_index in new Range((idxFermions[0L] + 1L), (idxFermions[1L] - 1L)))
#line hidden
                    {
#line 194 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        total_gates[qubit_index] = Pauli.PauliZ;
                    }

#line 198 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    foreach (var qubit_index in new Range((idxFermions[1L] + 1L), (idxFermions[3L] - 1L)))
#line hidden
                    {
#line 199 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                        total_gates[qubit_index] = Pauli.PauliZ;
                    }

#line 202 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                    out_hold = (out_hold + new QArray<(IUnitary,QArray<Pauli>,Int64)>()
                    {(MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((__arg1__) => (total_gates?.Copy(), __arg1__))), total_gates?.Copy(), value)});
                }
            }

#line 205 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            return out_hold;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
            this.MicrosoftQuantumChemistryIsNotZero = this.Factory.Get<ICallable<Double, Boolean>>(typeof(Microsoft.Quantum.Chemistry.IsNotZero));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex generatorIndex, QArray<Qubit> qubits)
        {
            return __m__.Run<_SplitJW0123Term_, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((generatorIndex, qubits));
        }
    }

    public class CreatePauliSet : Operation<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>, ICallable
    {
        public CreatePauliSet(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>)>, IApplyData
        {
            public In((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "CreatePauliSet";
        String ICallable.FullName => "MultiUnitary.CreatePauliSet";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> _SplitJW0123Term_
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> _SplitJWZTerm_
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> _SplitJWZZTerm_
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> _SplitPQandPQQRTerm_
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> Body => (__in__) =>
        {
            var (generatorIndex,qubits) = __in__;
#line 210 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var ((idxTermType,idxDoubles),idxFermions) = generatorIndex.Data;
#line 211 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            var termType = idxTermType[0L];
#line 213 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
            if ((termType == 0L))
            {
#line 215 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return _SplitJWZTerm_.Apply((generatorIndex, qubits?.Copy()));
            }
            else if ((termType == 1L))
            {
#line 219 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return _SplitJWZZTerm_.Apply((generatorIndex, qubits?.Copy()));
            }
            else if ((termType == 2L))
            {
#line 223 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return _SplitPQandPQQRTerm_.Apply((generatorIndex, qubits?.Copy()));
            }
            else if ((termType == 3L))
            {
#line 227 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return _SplitJW0123Term_.Apply((generatorIndex, qubits?.Copy()));
            }
            else
            {
#line 230 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                Message.Apply("OTHER IS INVOLVED");
#line 231 "/Users/Julian/polybox/490Qproject/VQE/ResourceEstimation/MultiUnitary.qs"
                return new QArray<(IUnitary,QArray<Pauli>,Int64)>(0L);
            }
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this._SplitJW0123Term_ = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(_SplitJW0123Term_));
            this._SplitJWZTerm_ = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(_SplitJWZTerm_));
            this._SplitJWZZTerm_ = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(_SplitJWZZTerm_));
            this._SplitPQandPQQRTerm_ = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(_SplitPQandPQQRTerm_));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(IUnitary,QArray<Pauli>,Int64)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(IUnitary,QArray<Pauli>,Int64)>> Run(IOperationFactory __m__, Microsoft.Quantum.Canon.GeneratorIndex generatorIndex, QArray<Qubit> qubits)
        {
            return __m__.Run<CreatePauliSet, (Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>((generatorIndex, qubits));
        }
    }
}