#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"create_generator\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qSharpData\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":66}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorSystem\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":86}}]}}]},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"create_generator\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"Simulate_Variational\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":64}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"moe\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":69}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":109}}]}}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerInputState\",\"Range\":{\"Case\":\"Null\"}}]}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"Simulate_Variational\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"Simulate\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":52}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"moe\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"runs\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Chemistry.JordanWigner\",\"Name\":\"JordanWignerEncodingData\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"Double\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Double\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"Simulate\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"prepareStateHelper\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"coeffs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"ComplexPolar\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":52}}]}}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"ComplexPolar\",\"Range\":{\"Case\":\"Null\"}}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"prepareStateHelper\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"SumExpectedValues\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial_oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"HamiltonianGates\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorSystem\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":2,\"Column\":52},\"Item2\":{\"Line\":2,\"Column\":67}}]}}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":33},\"Item2\":{\"Line\":2,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":33},\"Item2\":{\"Line\":3,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"moe\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":52},\"Item2\":{\"Line\":3,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"GeneratorSystem\",\"Range\":{\"Case\":\"Null\"}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"SumExpectedValues\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"FindExpectedValue\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":175,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"InitialStateOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gate\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":33},\"Item2\":{\"Line\":2,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"measure_basis\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":59},\"Item2\":{\"Line\":2,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":33},\"Item2\":{\"Line\":3,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"moe\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":52},\"Item2\":{\"Line\":3,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"FindExpectedValue\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":175,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"MarginOfError\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":221,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"probability\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"runs\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Z_SCORE\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Double\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"MarginOfError\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":221,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"VQE\",\"Name\":\"RunSingleIteration\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":227,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"InitialStateOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"MysteryGate\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":34},\"Item2\":{\"Line\":2,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"basis\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":67},\"Item2\":{\"Line\":2,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":84},\"Item2\":{\"Line\":2,\"Column\":91}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Pauli\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"VQE\",\"Name\":\"RunSingleIteration\"},\"SourceFile\":\"C:/Users/keepw/Documents/GitHub/490Qproject/VQE/Sample1.0/Operations.qs\",\"Position\":{\"Item1\":227,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace VQE
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
        String ICallable.FullName => "VQE.create_generator";
        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JWOptimizedHTerms, Microsoft.Quantum.Canon.GeneratorSystem> MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)> Body => (__in__) =>
        {
            var qSharpData = __in__;
#line 21 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (nSpinOrbitals,data,statePrepData,energyShift) = qSharpData.Data;
#line 26 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var generatorSystem = MicrosoftQuantumChemistryJordanWignerJordanWignerGeneratorSystem.Apply(data);
#line 28 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
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

    public class Simulate_Variational : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>), Double>, ICallable
    {
        public Simulate_Variational(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Simulate_Variational";
        String ICallable.FullName => "VQE.Simulate_Variational";
        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double> SumExpectedValues
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)> create_generator
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>), Double> Body => (__in__) =>
        {
            var (data,moe,input) = __in__;
#line 36 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = data.Data;
#line 40 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (ham_terms,nOrbitals) = create_generator.Apply(data);
#line 45 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var energy = 0D;
#line hidden
            {
#line 48 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var testQ = Allocate.Apply(nOrbitals);
#line 50 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var initial_oracle = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((__arg1__) => (input?.Copy(), __arg1__)));
#line 53 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                energy = (SumExpectedValues.Apply((initial_oracle, ham_terms, testQ?.Copy(), moe)) + energyOffset);
#line hidden
                Release.Apply(testQ);
            }

#line 55 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return energy;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.SumExpectedValues = this.Factory.Get<ICallable<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double>>(typeof(SumExpectedValues));
            this.create_generator = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)>>(typeof(create_generator));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data, Double moe, QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState> input)
        {
            return __m__.Run<Simulate_Variational, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>), Double>((data, moe, input));
        }
    }

    public class Simulate : Operation<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), QArray<QArray<Double>>>, ICallable
    {
        public Simulate(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64)>, IApplyData
        {
            public In((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Simulate";
        String ICallable.FullName => "VQE.Simulate";
        protected ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid> MicrosoftQuantumChemistryJordanWignerPrepareTrialState
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

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

        protected ICallable<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double> SumExpectedValues
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)> create_generator
        {
            get;
            set;
        }

        public override Func<(Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), QArray<QArray<Double>>> Body => (__in__) =>
        {
            var (data,moe,runs) = __in__;
#line 67 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (nSpinOrbitals,fermionTermData,statePrepData,energyOffset) = data.Data;
#line 70 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var out_val = new QArray<QArray<Double>>(0L);
#line 74 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (ham_terms,nOrbitals) = create_generator.Apply(data);
#line 76 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            Message.Apply(String.Format("{0}", nOrbitals));
#line 79 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var ground_energy = 1000D;
#line 80 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var ground_phase = 3D;
#line 81 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var index = 0L;
#line hidden
            {
#line 84 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var testQ = Allocate.Apply(nOrbitals);
#line 85 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var run_num = 0L;
#line 86 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                while (true)
                {
#line 87 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    var temp_out_array = new QArray<QArray<Double>>(1L);
#line 94 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    var initial_oracle = MicrosoftQuantumChemistryJordanWignerPrepareTrialState.Partial(new Func<QArray<Qubit>, (QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>)>((__arg1__) => (statePrepData?.Copy(), __arg1__)));
#line 98 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    var discovered_energy = (SumExpectedValues.Apply((initial_oracle, ham_terms, testQ?.Copy(), moe)) + energyOffset);
#line 101 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    temp_out_array[0L] = new QArray<Double>(MicrosoftQuantumExtensionsConvertToDouble.Apply(run_num), discovered_energy);
#line 104 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    out_val = (out_val + temp_out_array);
#line 117 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    index = (index + 1L);
#line 120 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    run_num = (run_num + 1L);
                    if ((run_num >= runs))
                    {
                        break;
                    }
                    else
                    {
                    }
                }

#line hidden
                Release.Apply(testQ);
            }

#line 128 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return out_val;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumChemistryJordanWignerPrepareTrialState = this.Factory.Get<ICallable<(QArray<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerInputState>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Chemistry.JordanWigner.PrepareTrialState));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.SumExpectedValues = this.Factory.Get<ICallable<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double>>(typeof(SumExpectedValues));
            this.create_generator = this.Factory.Get<ICallable<Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData, (Microsoft.Quantum.Canon.GeneratorSystem,Int64)>>(typeof(create_generator));
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Double>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Double>>> Run(IOperationFactory __m__, Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData data, Double moe, Int64 runs)
        {
            return __m__.Run<Simulate, (Microsoft.Quantum.Chemistry.JordanWigner.JordanWignerEncodingData,Double,Int64), QArray<QArray<Double>>>((data, moe, runs));
        }
    }

    public class prepareStateHelper : Operation<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>), QVoid>, ICallable
    {
        public prepareStateHelper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "prepareStateHelper";
        String ICallable.FullName => "VQE.prepareStateHelper";
        protected IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonPrepareArbitraryState
        {
            get;
            set;
        }

        public override Func<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (coeffs,qs) = __in__;
#line 133 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            MicrosoftQuantumCanonPrepareArbitraryState.Apply((coeffs?.Copy(), new Microsoft.Quantum.Canon.BigEndian(qs?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonPrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
        }

        public override IApplyData __dataIn((QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Microsoft.Quantum.Canon.ComplexPolar> coeffs, QArray<Qubit> qs)
        {
            return __m__.Run<prepareStateHelper, (QArray<Microsoft.Quantum.Canon.ComplexPolar>,QArray<Qubit>), QVoid>((coeffs, qs));
        }
    }

    public class SumExpectedValues : Operation<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double>, ICallable
    {
        public SumExpectedValues(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double)>, IApplyData
        {
            public In((ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2?.Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "SumExpectedValues";
        String ICallable.FullName => "VQE.SumExpectedValues";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>> MultiUnitaryCreatePauliSet
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double), Double> FindExpectedValue
        {
            get;
            set;
        }

        public override Func<(ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double> Body => (__in__) =>
        {
            var (initial_oracle,HamiltonianGates,ancilla,moe) = __in__;
#line 143 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var total = 0D;
#line 149 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var (num_of_terms,jw_term_indexer) = HamiltonianGates.Data;
#line 152 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            foreach (var i in new Range(0L, (num_of_terms - 1L)))
#line hidden
            {
#line 155 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var jw_term = jw_term_indexer.Apply<Microsoft.Quantum.Canon.GeneratorIndex>(i);
#line 158 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                var gate_basis_pairs = MultiUnitaryCreatePauliSet.Apply((jw_term, ancilla?.Copy()));
#line 161 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                foreach (var gate_combo in new Range(0L, (gate_basis_pairs.Length - 1L)))
#line hidden
                {
#line 164 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    var (gate_to_evaluate,basis,value) = gate_basis_pairs[gate_combo];
#line 167 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    var ((gate_keys,weight),targets) = jw_term.Data;
#line 170 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    total = (total + (weight[0L] * FindExpectedValue.Apply((initial_oracle, gate_to_evaluate, basis?.Copy(), ancilla?.Copy(), moe))));
                }
            }

#line 173 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return total;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MultiUnitaryCreatePauliSet = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.GeneratorIndex,QArray<Qubit>), QArray<(IUnitary,QArray<Pauli>,Int64)>>>(typeof(MultiUnitary.CreatePauliSet));
            this.FindExpectedValue = this.Factory.Get<ICallable<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double), Double>>(typeof(FindExpectedValue));
        }

        public override IApplyData __dataIn((ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ICallable initial_oracle, Microsoft.Quantum.Canon.GeneratorSystem HamiltonianGates, QArray<Qubit> ancilla, Double moe)
        {
            return __m__.Run<SumExpectedValues, (ICallable,Microsoft.Quantum.Canon.GeneratorSystem,QArray<Qubit>,Double), Double>((initial_oracle, HamiltonianGates, ancilla, moe));
        }
    }

    public class FindExpectedValue : Operation<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double), Double>, ICallable
    {
        public FindExpectedValue(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double)>, IApplyData
        {
            public In((ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "FindExpectedValue";
        String ICallable.FullName => "VQE.FindExpectedValue";
        protected ICallable<(Double,Double,Double), Double> MarginOfError
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>), Boolean> RunSingleIteration
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double), Double> Body => (__in__) =>
        {
            var (InitialStateOracle,gate,measure_basis,ancilla,moe) = __in__;
#line 183 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var Z_SCORE = 1.96D;
#line 186 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var out_val = -(10D);
#line 189 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var run_sum = 0D;
#line 192 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var total_runs = 0D;
#line 195 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var error_term = 1D;
#line 197 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            while (true)
            {
#line 198 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                foreach (var i in new Range(0L, 10L))
#line hidden
                {
#line 200 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    if (RunSingleIteration.Apply((InitialStateOracle, gate, measure_basis?.Copy(), ancilla?.Copy())))
                    {
#line 202 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                        run_sum = (run_sum + 1D);
                    }

#line 204 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                    total_runs = (total_runs + 1D);
                }

#line 208 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                out_val = (run_sum / total_runs);
#line 211 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
                error_term = MarginOfError.Apply((out_val, total_runs, Z_SCORE));
                if (((error_term < moe) || (total_runs >= 50D)))
                {
                    break;
                }
                else
                {
                }
            }

#line 219 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return (1D - (2D * out_val));
        }

        ;
        public override void Init()
        {
            this.MarginOfError = this.Factory.Get<ICallable<(Double,Double,Double), Double>>(typeof(MarginOfError));
            this.RunSingleIteration = this.Factory.Get<ICallable<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>), Boolean>>(typeof(RunSingleIteration));
        }

        public override IApplyData __dataIn((ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ICallable InitialStateOracle, ICallable gate, QArray<Pauli> measure_basis, QArray<Qubit> ancilla, Double moe)
        {
            return __m__.Run<FindExpectedValue, (ICallable,ICallable,QArray<Pauli>,QArray<Qubit>,Double), Double>((InitialStateOracle, gate, measure_basis, ancilla, moe));
        }
    }

    public class MarginOfError : Function<(Double,Double,Double), Double>, ICallable
    {
        public MarginOfError(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,Double)>, IApplyData
        {
            public In((Double,Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MarginOfError";
        String ICallable.FullName => "VQE.MarginOfError";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<(Double,Double,Double), Double> Body => (__in__) =>
        {
            var (probability,runs,Z_SCORE) = __in__;
#line 225 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return (Z_SCORE * MicrosoftQuantumExtensionsMathSqrt.Apply(((probability * (1D - probability)) / runs)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn((Double,Double,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double probability, Double runs, Double Z_SCORE)
        {
            return __m__.Run<MarginOfError, (Double,Double,Double), Double>((probability, runs, Z_SCORE));
        }
    }

    public class RunSingleIteration : Operation<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>), Boolean>, ICallable
    {
        public RunSingleIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,ICallable,QArray<Pauli>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "RunSingleIteration";
        String ICallable.FullName => "VQE.RunSingleIteration";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable,QArray<Pauli>,QArray<Qubit>), Boolean> Body => (__in__) =>
        {
            var (InitialStateOracle,MysteryGate,basis,ancilla) = __in__;
#line 235 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            InitialStateOracle.Apply(ancilla?.Copy());
#line 238 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            MysteryGate.Apply(ancilla?.Copy());
#line 242 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            var out_val = ((Measure.Apply((basis?.Copy(), ancilla?.Copy())) == Result.One) ? true : false);
#line 245 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            ResetAll.Apply(ancilla?.Copy());
#line 247 "C:\\Users\\keepw\\Documents\\GitHub\\490Qproject\\VQE\\Sample1.0\\Operations.qs"
            return out_val;
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((ICallable,ICallable,QArray<Pauli>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, ICallable InitialStateOracle, ICallable MysteryGate, QArray<Pauli> basis, QArray<Qubit> ancilla)
        {
            return __m__.Run<RunSingleIteration, (ICallable,ICallable,QArray<Pauli>,QArray<Qubit>), Boolean>((InitialStateOracle, MysteryGate, basis, ancilla));
        }
    }
}