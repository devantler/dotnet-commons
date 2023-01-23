namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# enum value
/// </summary>
public static class CSharpEnumSymbolTemplate
{
    /// <summary>
    /// Gets the enum value template text
    /// </summary>
    public static string GetTemplate() =>
        """
        {{ $1.name }}{{ if !($1.value | string.empty) }} = {{ $1.value }}{{ end }}
        """;
}
