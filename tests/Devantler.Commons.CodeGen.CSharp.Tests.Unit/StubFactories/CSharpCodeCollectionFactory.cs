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

    internal static object CreateCSharpCodeCollectionStubWithOneEmptyInterface()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = new CSharpInterface("InterfaceName", "Namespace", "Interface documentation block");

        _ = compilation.AddInterface(@interface);

        return compilation;
    }
    internal static object CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithSingleMembers()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(1, 1, true);

        _ = compilation.AddInterface(@interface);

        return compilation;
    }
    internal static object CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithMultipleMembers()
    {
        var compilation = new CSharpCompilation();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(2, 2, true);

        _ = compilation.AddInterface(@interface);

        return compilation;
    }
}
