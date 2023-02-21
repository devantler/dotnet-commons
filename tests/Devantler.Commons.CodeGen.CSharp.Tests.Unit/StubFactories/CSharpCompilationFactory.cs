using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

static class CSharpCodeCompilationFactory
{
    internal static CSharpCompilation CreateCSharpCodeCompilationStub(
        Action<CSharpInterfaceOptions>? interfaceOptionsAction = null,
        Action<CSharpClassOptions>? classOptionsAction = null,
        Action<CSharpEnumOptions>? enumOptionsAction = null
    )
    {
        var interfaceOptions = new CSharpInterfaceOptions();
        interfaceOptionsAction?.Invoke(interfaceOptions);

        var classOptions = new CSharpClassOptions();
        classOptionsAction?.Invoke(classOptions);

        var enumOptions = new CSharpEnumOptions();
        enumOptionsAction?.Invoke(enumOptions);

        var compilation = new CSharpCompilation();

        for (int i = 0; i < interfaceOptions.Count; i++)
        {
            var @interface = CSharpInterfaceFactory.CreateCSharpInterface(interfaceOptions, i);
            _ = compilation.AddType(@interface);
        }

        for (int i = 0; i < classOptions.Count; i++)
        {
            var @class = CSharpClassFactory.CreateCSharpClass(classOptions, i);

            _ = compilation.AddType(@class);
        }

        for (int i = 0; i < enumOptions.Count; i++)
        {
            var @enum = CSharpEnumFactory.CreateCSharpEnum(enumOptions, i);

            _ = compilation.AddType(@enum);
        }

        return compilation;
    }
}
