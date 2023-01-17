using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

static class CSharpCodeCollectionFactory
{
    internal static CSharpCompilation CreateEmptyCSharpCodeCollectionStub() => new();

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOneEmptyClass()
    {
        var compilation = new CSharpCompilation();

        ClassBase @class = new CSharpClass("ClassName", "Namespace", "Class documentation block");

        _ = compilation.AddClass(@class);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedClassWithSingleMembers()
    {
        var compilation = new CSharpCompilation();

        ClassBase @class = CSharpClassFactory.CreateCSharpClass(1, 1, 1, 1, true);

        _ = compilation.AddClass(@class);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedClassWithMultipleMembers()
    {
        var compilation = new CSharpCompilation();

        ClassBase @class = CSharpClassFactory.CreateCSharpClass(2, 2, 2, 2, true);

        _ = compilation.AddClass(@class);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOneEmptyInterface()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = new CSharpInterface("InterfaceName", "Namespace", "Interface documentation block");

        _ = compilation.AddInterface(@interface);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithSingleMembers()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(1, 1, true);

        _ = compilation.AddInterface(@interface);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithMultipleMembers()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(2, 2, true);

        _ = compilation.AddInterface(@interface);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOneEmptyEnum()
    {
        var compilation = new CSharpCompilation();

        EnumBase @enum = new CSharpEnum("EnumName", "Namespace", "Enum documentation block");

        _ = compilation.AddEnum(@enum);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithSingleValue()
    {
        var compilation = new CSharpCompilation();

        EnumBase @enum = CSharpEnumFactory.CreateCSharpEnum(1);

        _ = compilation.AddEnum(@enum);

        return compilation;
    }

    internal static CSharpCompilation CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithMultipleValues()
    {
        var compilation = new CSharpCompilation();

        EnumBase @enum = CSharpEnumFactory.CreateCSharpEnum(2);

        _ = compilation.AddEnum(@enum);

        return compilation;
    }
}
