namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# field
/// </summary>
public static class CSharpFieldTemplate
{
    /// <summary>
    /// Gets the field template text
    /// </summary>
    public static string GetTemplate() => """
    {{~ if $1.doc_block != null }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
    {{ $1.visibility | string.downcase }} {{ $1.type }} {{ $1.name }}{{ if $1.value != null }} = {{ $1.value }}{{ end }};
    """;
}
