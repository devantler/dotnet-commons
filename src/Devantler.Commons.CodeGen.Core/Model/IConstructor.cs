namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
/// An interface representing a constructor.
/// </summary>
public interface IConstructor
{
    /// <summary>
    ///     The visibility of the constructor.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    ///     The name of the constructor.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The statements in the constructor.
    /// </summary>
    public string? Body { get; }

    /// <summary>
    ///     The documentation block describing the constructor.
    /// </summary>
    public IDocBlock? DocBlock { get; }

    /// <summary>
    ///     The parameters accepted by the constructor.
    /// </summary>
    public List<IConstructorParameter> Parameters { get; }
}
