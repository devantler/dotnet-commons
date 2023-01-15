using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# documentation block.
/// </summary>
public class CSharpDocumentationBlock : DocumentationBlockBase
{
    /// <summary>
    /// Creates a new instance of <see cref="DocumentationBlockBase" />.
    /// </summary>
    /// <param name="summary"></param>
    public CSharpDocumentationBlock(string summary) : base(summary)
    {
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        /// <summary>
        /// {{Summary}}
        /// </summary>
        {{string.Join(Environment.NewLine, Parameters.Select(p => $"/// <param name=\"{p}\"></param>"))}}
        """.TrimEnd(Environment.NewLine.ToCharArray());
}
