using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
/// A model representing a C# enum value.
/// </summary>
/// <remarks>
/// Creates a new C# enum value.
/// </remarks>
/// <param name="name"></param>
public class CSharpEnumSymbol(string name) : IFluentEnumValue<CSharpEnumSymbol>
{
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string? Value { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public CSharpEnumSymbol SetValue(int value)
    {
        Value = value.ToString();
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnumSymbol SetValue(string value)
    {
        Value = value;
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnumSymbol SetValue(Enum value)
    {
        Value = value.ToString();
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnumSymbol SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <summary>
    /// The template for a C# enum value.
    /// </summary>
    public static string Template =>
        """
        {{~ if $1.doc_block ~}}
        {{ include 'doc_block' $1.doc_block }}
        {{- end ~}}
        {{ $1.name }}{{ if !($1.value | string.empty) }} = {{ $1.value }}{{ end }}
        """;
}
