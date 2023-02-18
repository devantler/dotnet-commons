using System.Globalization;
using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpEnumFactory
{
    internal static CSharpEnum CreateCSharpEnum(CSharpEnumOptions options, int index)
    {
        var @enum = new CSharpEnum($"EnumName{index}")
            .SetNamespace(options.IncludeNamespace ? "Namespace" : "");

        if (options.IncludeDocumentation)
            _ = @enum.SetDocBlock(new CSharpDocBlock("Enum documentation block"));

        _ = @enum.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < options.SymbolsCount; i++)
        {
            var symbol = (i % 2 == 0)
                ? new CSharpEnumSymbol($"Value{i}")
                : new CSharpEnumSymbol($"Value{i}")
                    .SetValue(i.ToString(CultureInfo.CurrentCulture));
            _ = @enum.AddValue(symbol);
        }

        return @enum;
    }
}
