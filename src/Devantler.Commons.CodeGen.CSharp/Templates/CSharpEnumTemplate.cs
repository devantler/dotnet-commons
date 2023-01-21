namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# enum
/// </summary>
public static class CSharpEnumTemplate
{
    /// <summary>
    /// Gets the enum template text
    /// </summary>
    public static string GetTemplate() => """
    {{- for using in imports ~}}
    {{ include 'using' using }}
    {{~ end ~}}
    {{~ if !(namespace | string.empty) ~}}
    {{ include 'namespace' namespace }}
    {{~ end ~}}
    {{~ if doc_block ~}}
    {{ include 'doc_block' doc_block }}
    {{- end ~}}
    public enum {{ name }}
    {
    {{~ for value in values ~}}
        {{ include 'enum_value' value }}{{ if !for.last }},{{ end }}
    {{~ end ~}}
    }
    """;
}
