using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

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
            InterfaceBase @interface = CSharpInterfaceFactory.CreateCSharpInterface(interfaceOptions, i);

            _ = compilation.AddInterface(@interface);
        }

        for (int i = 0; i < classOptions.Count; i++)
        {
            ClassBase @class = CSharpClassFactory.CreateCSharpClass(classOptions, i);

            _ = compilation.AddClass(@class);
        }

        for (int i = 0; i < enumOptions.Count; i++)
        {
            EnumBase @enum = CSharpEnumFactory.CreateCSharpEnum(enumOptions, i);

            _ = compilation.AddEnum(@enum);
        }

        return compilation;
    }
}
