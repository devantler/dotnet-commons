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
}
