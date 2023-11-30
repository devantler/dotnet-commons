using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# field.
/// </summary>
/// <remarks>
/// Creates a new C# field.
/// </remarks>
/// <param name="type"></param>
/// <param name="name"></param>
public class CSharpField(string type, string name) : IFluentField<CSharpField>
{
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public string Type { get; set; } = type;
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string? Value { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public CSharpField SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <inheritdoc/>
    public CSharpField SetValue(string? value)
    {
        Value = value;
        return this;
    }
    /// <inheritdoc/>
    public CSharpField SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }
    /// <summary>
    /// The template for a C# field.
    /// </summary>
    public static string Template =>
        """
        {{~ if $1.type | string.ends_with "?" ~}}
        #nullable enable
        {{~ end ~}}
        {{~ if $1.doc_block != null }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{ $1.visibility != "Private" ? ($1.visibility | string.downcase) + " " : ""}}{{ $1.type }} {{ $1.name }}{{~ if $1.value != null }} = {{ $1.value }};{{ else }};{{ end ~}}
        {{~ if $1.type | string.ends_with "?" }}
        #nullable disable
        {{- end ~}}
        """;
}
