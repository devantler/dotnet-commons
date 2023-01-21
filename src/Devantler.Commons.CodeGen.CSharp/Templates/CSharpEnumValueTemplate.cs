namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# enum value
/// </summary>
public static class CSharpEnumValueTemplate
{
    /// <summary>
    /// Gets the enum value template text
    /// </summary>
    public static string GetTemplate() => """{{ $1.name }} = {{ $1.value }}""";
}
