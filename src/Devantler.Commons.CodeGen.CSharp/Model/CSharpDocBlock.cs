using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# documentation block.
/// </summary>
public class CSharpDocBlock : IFluentDocBlock<CSharpDocBlock>
{
    /// <summary>
    /// Creates a new C# documentation block.
    /// </summary>
    /// <param name="summary"></param>
    public CSharpDocBlock(string summary) => Summary = summary;
    /// <inheritdoc/>
    public string Summary { get; set; }
    /// <inheritdoc/>
    public List<IDocBlockParameter> Parameters { get; set; } = new();
    /// <inheritdoc/>
    public CSharpDocBlock AddParameter(IDocBlockParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
    /// <summary>
    /// The template for a C# documentation block.
    /// </summary>
    public static string Template =>
        """
        /// <summary>
        /// {{ $1.summary }}
        /// </summary>
        {{~ for parameter in $1.parameters ~}}
        /// {{ include 'doc_block_parameter' parameter }}
        {{~ end ~}}
        """;
}
