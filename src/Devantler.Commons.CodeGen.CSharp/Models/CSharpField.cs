using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# field.
/// </summary>
public class CSharpField : FieldBase
{
    /// <summary>
    /// Creates a new field.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="documentation"></param>
    public CSharpField(Visibility visibility, string type, string name, string? value = default, string? documentation = default) : base(visibility, type, name, value)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocumentationBlock = new CSharpDocumentationBlock(documentation);
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        {{DocumentationBlock?.Compile()}}
        {{Visibility.ToString().ToLower()}} {{Type}} {{Name.ToCamelCase()}} {{(Value is not null ? "= " + Value : "")}};
        """;
}
