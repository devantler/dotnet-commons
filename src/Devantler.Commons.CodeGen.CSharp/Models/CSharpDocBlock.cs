using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# documentation block.
/// </summary>
public class CSharpDocBlock : DocBlockBase
{
    /// <summary>
    ///     Creates a new documentation block.
    /// </summary>
    /// <param name="summary"></param>
    public CSharpDocBlock(string summary) : base(summary)
    {
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
