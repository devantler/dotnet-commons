using System.Globalization;
using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpEnumFactory
{
    internal static CSharpEnum CreateCSharpEnum(CSharpEnumOptions options, int index)
    {
        var @enum = new CSharpEnum($"Enum{index}")
            .SetVisibility(options.Visibility);

        if (options.IncludeNamespace)
            _ = @enum.SetNamespace("Namespace");

        if (options.IncludeDocumentation)
            _ = @enum.SetDocBlock(new CSharpDocBlock("Enum documentation block"));

        if (options.IncludeUsing)
            _ = @enum.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < options.EnumSymbolOptions.Count; i++)
        {
            var symbol = new CSharpEnumSymbol($"Value{i}");

            if (options.EnumSymbolOptions.IncludeDocumentation)
                _ = symbol.SetDocBlock(new CSharpDocBlock($"Enum symbol documentation block {i}"));

            if (options.EnumSymbolOptions.IncludeValue)
                _ = symbol.SetValue(i.ToString(CultureInfo.CurrentCulture));

            _ = @enum.AddValue(symbol);
        }

        return @enum;
    }
}
