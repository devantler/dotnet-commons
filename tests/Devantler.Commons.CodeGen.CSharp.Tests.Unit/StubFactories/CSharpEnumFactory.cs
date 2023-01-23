using System.Globalization;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpEnumFactory
{
    internal static CSharpEnum CreateCSharpEnum(int numberOfSymbols, bool hasNamespaces)
    {
        var @enum = new CSharpEnum("EnumName", hasNamespaces ? "Namespace" : "", "Enum documentation block");

        _ = @enum.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < numberOfSymbols; i++)
        {
            var symbol = (i % 2 == 0)
                ? new CSharpEnumSymbol($"Value{i}")
                : new CSharpEnumSymbol($"Value{i}", i.ToString(CultureInfo.CurrentCulture));
            _ = @enum.AddValue(symbol);
        }

        return @enum;
    }
}
