namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# interface
/// </summary>
public static class CSharpInterfaceTemplate
{
    /// <summary>
    /// Gets the interface template text
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
    public interface {{ name }}
    {
    {{~ for property in properties ~}}
        {{ include 'property' property }}
    {{~ end ~}}
    {{~ for method in methods ~}}
        {{ include 'method' method }}
    {{~ end ~}}
    }
    """;
}
