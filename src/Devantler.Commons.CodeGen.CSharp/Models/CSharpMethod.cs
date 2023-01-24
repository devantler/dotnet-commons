using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# method.
/// </summary>
public class CSharpMethod : MethodBase
{
    /// <summary>
    ///     Creates a new method.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    public CSharpMethod(Visibility visibility, string type, string name, string? body = null,
        IDocBlock? documentationBlock = null) : base(visibility, type, name, body, documentationBlock)
    {
    }

    /// <summary>
    /// The template for a C# method.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{ $1.visibility | string.downcase }} {{ $1.type }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
        {
        {{~ }}    {{ $1.body }}
        }
        """;
}
