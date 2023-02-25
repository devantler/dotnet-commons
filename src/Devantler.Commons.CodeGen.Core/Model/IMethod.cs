namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
/// An interface representing a method.
/// </summary>
public interface IMethod
{
    /// <summary>
    /// The visibility of the method.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    /// The name of the method.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The return type of the method.
    /// </summary>
    public string ReturnType { get; }

    /// <summary>
    /// Whether a method should override a base method or not.
    /// </summary>
    public bool IsOverride { get; }

    /// <summary>
    /// Whether a method is static or not.
    /// </summary>
    public bool IsStatic { get; }

    /// <summary>
    /// Whether a method is asynchronous or not.
    /// </summary>
    public bool IsAsynchronous { get; }

    /// <summary>
    /// The statements in the body of the method.
    /// </summary>
    public List<string> Statements { get; }

    /// <summary>
    ///     The documentation block for the method.
    /// </summary>
    public IDocBlock? DocBlock { get; }

    /// <summary>
    /// The parameters accepted by the method.
    /// </summary>
    public List<IParameter> Parameters { get; }
}
