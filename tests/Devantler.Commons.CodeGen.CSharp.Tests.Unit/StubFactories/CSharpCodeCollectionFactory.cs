using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

static class CSharpCodeCollectionFactory
{
    internal static CSharpCodeCollection CreateEmptyCSharpCodeCollectionStub() => new();

    internal static CSharpCodeCollection CreateCSharpCodeCollectionStubWithOneEmptyClass()
    {
        var codeCollection = new CSharpCodeCollection();

        ClassBase @class = new CSharpClass("ClassName", "Namespace", "Class documentation block");

        codeCollection.AddCompilableUnit(@class);

        return codeCollection;
    }

    internal static CSharpCodeCollection CreateCSharpCodeCollectionStubWithOnePopulatedClassWithSingleMembers()
    {
        var codeCollection = new CSharpCodeCollection();

        ClassBase @class = CSharpClassFactory.CreateCSharpClass(1, 1, 1, 1, true);

        codeCollection.AddCompilableUnit(@class);

        return codeCollection;
    }

    internal static CSharpCodeCollection CreateCSharpCodeCollectionStubWithOnePopulatedClassWithMultipleMembers()
    {
        var codeCollection = new CSharpCodeCollection();

        ClassBase @class = CSharpClassFactory.CreateCSharpClass(2, 2, 2, 2, true);

        codeCollection.AddCompilableUnit(@class);

        return codeCollection;
    }

    internal static object CreateCSharpCodeCollectionStubWithOneEmptyInterface()
    {
        var codeCollection = new CSharpCodeCollection();

        InterfaceBase @interface = new CSharpInterface("InterfaceName", "Namespace", "Interface documentation block");

        codeCollection.AddCompilableUnit(@interface);

        return codeCollection;
    }
    internal static object CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithSingleMembers()
    {
        var codeCollection = new CSharpCodeCollection();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(1, 1, true);

        codeCollection.AddCompilableUnit(@interface);

        return codeCollection;
    }
    internal static object CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithMultipleMembers()
    {
        var codeCollection = new CSharpCodeCollection();

        InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(2, 2, true);

        codeCollection.AddCompilableUnit(@interface);

        return codeCollection;
    }
}
