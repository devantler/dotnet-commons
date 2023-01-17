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
}
