namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# method
/// </summary>
public static class CSharpMethodTemplate
{
    /// <summary>
    /// Gets the method template text
    /// </summary>
    public static string GetTemplate() => """
    {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
    {{ $1.visibility | string.downcase }} {{ $1.type }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
    {
    {{~ }}    {{ $1.body }}
    }
    """;
}
