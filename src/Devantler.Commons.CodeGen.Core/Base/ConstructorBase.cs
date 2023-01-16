using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for constructors.
/// </summary>
public abstract class ConstructorBase : IConstructor
{
    /// <inheritdoc/>
    public Visibility Visibility { get; }
    /// <inheritdoc/>
    public string Name { get; }
    /// <inheritdoc/>
    public string? Body { get; }
    /// <inheritdoc/>
    public DocBlockBase? DocBlock { get; }
    /// <inheritdoc/>
    public List<IDocBlockParameter> Parameters { get; } = new();

    /// <summary>
    /// Creates a new constructor.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    protected ConstructorBase(Visibility visibility, string name, string? body = null, DocBlockBase? documentationBlock = null)
    {
        Visibility = visibility;
        Name = name;
        Body = body;
        DocBlock = documentationBlock;
    }
}
