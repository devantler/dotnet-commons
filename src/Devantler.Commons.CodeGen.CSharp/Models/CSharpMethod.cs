using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# method.
/// </summary>
public class CSharpMethod : MethodBase
{
    /// <summary>
    /// Creates a new method.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="returnType"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    public CSharpMethod(Visibility visibility, string returnType, string name, string? body = null, DocumentationBlockBase? documentationBlock = null) : base(visibility, returnType, name, body, documentationBlock)
    {
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        {{DocumentationBlock?.Compile()}}
        {{Visibility.ToString().ToLower()}} {{ReturnType}} {{Name}}({{string.Join(", ", Parameters.Select(p => p.Compile()))}})
        {
            {{Body}}
        }
        """;
}
