using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# property.
/// </summary>
public class CSharpProperty : IFluentProperty<CSharpProperty>
{
    /// <summary>
    /// Creates a new C# property.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    public CSharpProperty(string type, string name)
    {
        Name = name;
        Type = type;
    }
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public string Type { get; set; }
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Value { get; set; }
    /// <inheritdoc/>
    public bool IsExpressionBodiedMember { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public CSharpProperty SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }
    /// <inheritdoc/>
    public CSharpProperty SetValue(string value)
    {
        Value = value;
        return this;
    }

    /// <inheritdoc/>
    public CSharpProperty SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }

    /// <summary>
    /// Sets whether the property should use expression-bodied members or not.
    /// </summary>
    /// <param name="isExpressionBodiedMember"></param>
    public CSharpProperty SetIsExpressionBodiedMember(bool isExpressionBodiedMember)
    {
        IsExpressionBodiedMember = isExpressionBodiedMember;
        return this;
    }

    /// <summary>
    /// The template for a C# property.
    /// </summary>
    public static string Template =>
        """
        {{~ if property.type | string.ends_with "?" ~}}
        #nullable enable
        {{~ end ~}}
        {{~ if property.doc_block }}{{ include 'doc_block' property.doc_block }}{{ end ~}}
        {{ property.visibility != "Private" ? (property.visibility | string.downcase) + " " : ""}}{{ property.type }} {{ property.name }}{{ if property.is_expression_bodied_member }} =>{{ else }} { get; set; }{{ if property.value != null }} ={{ end }}{{ end }}{{ if property.value != null }} {{ property.value }};{{ end ~}}
        {{~ if property.type | string.ends_with "?" }}
        #nullable disable
        {{- end ~}}
        """;
}
