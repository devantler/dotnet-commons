namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# doc block
/// </summary>
public static class CSharpDocBlockTemplate
{
    /// <summary>
    /// Gets the doc block template text
    /// </summary>
    public static string GetTemplate() => """
    /// <summary>
    /// {{ $1.summary }}
    /// </summary>
    {{~ for parameter in $1.parameters ~}}
    /// {{ include 'doc_block_parameter' parameter }}
    {{~ end ~}}
    """;
}
