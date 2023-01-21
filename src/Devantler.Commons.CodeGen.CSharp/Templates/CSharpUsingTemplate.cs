namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# using
/// </summary>
public static class CSharpUsingTemplate
{
    /// <summary>
    /// Gets the using template text
    /// </summary>
    public static string GetTemplate() => "using {{ if $1.alias != null }}{{ $1.alias }} = {{ end }}{{ $1.name}};";
}
