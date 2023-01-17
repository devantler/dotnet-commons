using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# field.
/// </summary>
public class CSharpField : FieldBase
{
    /// <summary>
    ///     Creates a new field.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="documentation"></param>
    public CSharpField(Visibility visibility, string type, string name, string? value = default,
        string? documentation = default) : base(visibility, type, name.ToCamelCase(), value)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocBlock = new CSharpDocBlock(documentation);
    }

    /// <inheritdoc />
    public override DocBlockBase? DocBlock { get; }
}
