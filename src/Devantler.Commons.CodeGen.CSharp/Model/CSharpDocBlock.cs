using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# documentation block.
/// </summary>
/// <remarks>
/// Creates a new C# documentation block.
/// </remarks>
/// <param name="summary"></param>
public class CSharpDocBlock(string summary) : IFluentDocBlock<CSharpDocBlock>
{
    /// <inheritdoc/>
    public string Summary { get; set; } = summary;
    /// <inheritdoc/>
    public List<IDocBlockParameter> Parameters { get; set; } = [];
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
