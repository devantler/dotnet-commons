using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# property.
/// </summary>
public class CSharpProperty : PropertyBase
{
    /// <summary>
    ///     Creates a new property.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <param name="documentation"></param>
    public CSharpProperty(Visibility visibility, string type, string name, string? value = null,
        string? documentation = null) : base(visibility, type, name, value)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocBlock = new CSharpDocBlock(documentation);
    }

    /// <inheritdoc />
    public override DocBlockBase? DocBlock { get; }

    /// <summary>
    /// The template for a C# property.
    /// </summary>
    public static string Template =>
        """
        {{~ if property.type | string.ends_with "?" ~}}
        #nullable enable
        {{~ end ~}}
        {{~ if property.doc_block }}{{ include 'doc_block' property.doc_block }}{{ end ~}}
        {{ property.visibility | string.downcase }} {{ property.type }} {{ property.name }} { get; set; }{{ if property.value != null }} = {{ property.value }};{{ end }}
        {{~ if property.type | string.ends_with "?" -}}
        #nullable disable
        {{- end ~}}
        """;
}
