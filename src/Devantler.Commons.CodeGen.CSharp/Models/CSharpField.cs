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

    /// <summary>
    /// The template for a C# field.
    /// </summary>
    public static string Template =>
        """
        {{~ if $1.doc_block != null }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{ $1.visibility | string.downcase }} {{ $1.type }} {{ $1.name }}{{ if $1.value != null }} = {{ $1.value }}{{ end }};
        """;
}
