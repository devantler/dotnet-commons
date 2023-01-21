namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# class
/// </summary>
public static class CSharpClassTemplate
{
    /// <summary>
    /// Gets the class template text
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
    public class {{ name }}
    {
    {{~ for field in fields ~}}
        {{ include 'field' field }}
    {{~ end ~}}
    {{~ for constructor in constructors ~}}
        {{ include 'constructor' constructor }}
    {{~ end ~}}
    {{~ for property in properties ~}}
        {{ include 'property' property }}
    {{~ end ~}}
    {{~ for method in methods ~}}
        {{ include 'method' method }}
    {{~ end ~}}
    }
    """;
}
