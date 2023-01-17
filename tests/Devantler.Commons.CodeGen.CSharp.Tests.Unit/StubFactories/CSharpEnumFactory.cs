using System.Globalization;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpEnumFactory
{
    internal static CSharpEnum CreateCSharpEnum(int numberOfValues)
    {
        var @enum = new CSharpEnum("EnumName", "Namespace", "Enum documentation block");

        for (int i = 0; i < numberOfValues; i++)
        {
            var value = new CSharpEnumValue($"Value{i}", i.ToString(CultureInfo.CurrentCulture));
            _ = @enum.AddValue(value);
        }

        return @enum;
    }
}
