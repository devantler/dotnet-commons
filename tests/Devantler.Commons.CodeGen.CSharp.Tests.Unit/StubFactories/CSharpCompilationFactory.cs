using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

static class CSharpCodeCompilationFactory
{
    internal static CSharpCompilation CreateCSharpCodeCompilationStub(int numberOfInterfaces, int numberOfClasses, int numberOfEnums, int numberOfMembers, bool hasDocumentation)
    {
        var compilation = new CSharpCompilation();

        for (int i = 0; i < numberOfInterfaces; i++)
        {
            InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(numberOfMembers, numberOfMembers, hasDocumentation);

            _ = compilation.AddInterface(@interface);
        }

        for (int i = 0; i < numberOfClasses; i++)
        {
            ClassBase @class = CSharpClassFactory.CreateCSharpClass(numberOfMembers, numberOfMembers, numberOfMembers, numberOfMembers, hasDocumentation);

            _ = compilation.AddClass(@class);
        }

        for (int i = 0; i < numberOfEnums; i++)
        {
            EnumBase @enum = CSharpEnumFactory.CreateCSharpEnum(numberOfMembers);

            _ = compilation.AddEnum(@enum);
        }

        return compilation;
    }
}
