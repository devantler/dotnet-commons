using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# property.
/// </summary>
public class CSharpProperty : PropertyBase
{
    /// <inheritdoc/>
    public override DocBlockBase? DocBlock { get; }

    /// <summary>
    /// Creates a new property.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="documentation"></param>
    public CSharpProperty(Visibility visibility, string type, string name, string? value = null, string? documentation = null) : base(visibility, type, name, value)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocBlock = new CSharpDocBlock(documentation);
    }
}
