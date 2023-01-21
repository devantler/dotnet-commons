namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# property
/// </summary>
public static class CSharpPropertyTemplate
{
    /// <summary>
    /// Gets the property template text
    /// </summary>
    public static string GetTemplate() => """
    {{~ if property.doc_block }}{{ include 'doc_block' property.doc_block }}{{ end ~}}
    {{ property.visibility | string.downcase }} {{ property.type }} {{ property.name }} { get; set; }{{ if property.value != null }} = {{ property.value }};{{ end }}
    """;
}
