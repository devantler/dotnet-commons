namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# namespace
/// </summary>
public static class CSharpNamespaceTemplate
{
    /// <summary>
    /// Gets the namespace template text
    /// </summary>
    public static string GetTemplate() => """namespace {{ namespace }};""";
}
