using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# constructor.
/// </summary>
public class CSharpConstructor : ConstructorBase
{
    /// <inheritdoc />
    public CSharpConstructor(Visibility visibility, string name, string? body = null,
        DocBlockBase? documentationBlock = null) : base(visibility, name, body, documentationBlock)
    {
    }

    /// <summary>
    /// The template for a C# constructor.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{- $1.visibility | string.downcase }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
        {
        {{~ }}    {{ $1.body }}
        }
        """;
}
