using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# property.
/// </summary>
public class CSharpProperty : PropertyBase
{
    /// <summary>
    /// Creates a new property.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="documentation"></param>
    public CSharpProperty(Visibility visibility, string type, string name, string? value = default, string? documentation = default) : base(visibility, type, name, value)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocumentationBlock = new CSharpDocumentationBlock(documentation);
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        {{DocumentationBlock?.Compile()}}
        {{Visibility.ToString().ToLower()}} {{Type}} {{Name}} {{(Value is not null ? "= " + Value : "")}};
        """;
}
