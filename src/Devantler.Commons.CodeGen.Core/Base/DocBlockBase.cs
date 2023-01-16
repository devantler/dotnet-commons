using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for documentation blocks.
/// </summary>
public abstract class DocBlockBase : IDocBlock
{
    /// <inheritdoc/>
    public string Summary { get; }

    /// <inheritdoc/>
    public List<IDocBlockParameter> Parameters { get; } = new();

    /// <summary>
    /// Creates a new documentation block.
    /// </summary>
    /// <param name="summary"></param>
    protected DocBlockBase(string summary) => Summary = summary;

    /// <inheritdoc/>
    public IDocBlock AddParameter(IDocBlockParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
}
