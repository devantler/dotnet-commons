using System.Globalization;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpEnumFactory
{
    internal static CSharpEnum CreateCSharpEnum(int numberOfValues, bool hasNamespaces)
    {
        var @enum = new CSharpEnum("EnumName", hasNamespaces ? "Namespace" : "", "Enum documentation block");

        _ = @enum.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < numberOfValues; i++)
        {
            var value = new CSharpEnumValue($"Value{i}", i.ToString(CultureInfo.CurrentCulture));
            _ = @enum.AddValue(value);
        }

        return @enum;
    }
}
