namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a method.
/// </summary>
public interface IMethod
{
    /// <summary>
    ///     The visibility of the method.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    ///     The name of the method.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The return type of the method.
    /// </summary>
    public string ReturnType { get; }

    /// <summary>
    ///     The body of the method.
    /// </summary>
    public string? Body { get; }

    /// <summary>
    ///     The documentation block for the method.
    /// </summary>
    public IDocBlock? DocBlock { get; }

    /// <summary>
    ///     The parameters accepted by the method.
    /// </summary>
    public List<IParameter> Parameters { get; }
}
