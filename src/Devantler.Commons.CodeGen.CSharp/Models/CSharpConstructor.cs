using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# constructor.
/// </summary>
public class CSharpConstructor : ConstructorBase
{
    /// <summary>
    /// Creates a new constructor.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    public CSharpConstructor(Visibility visibility, string name, string? body = null, DocumentationBlockBase? documentationBlock = null) : base(visibility, name, body, documentationBlock)
    {
    }

    /// <inheritdoc/>
    public override string Compile() =>
    $$"""
    {{DocumentationBlock?.Compile()}}
    {{Visibility.ToString().ToLower()}} {{Name.ToPascalCase()}}({{string.Join(", ", Parameters.Select(p => p.Compile()))}})
    {
        {{Body}}
    }
    """;
}
