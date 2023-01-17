using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.Core.Interfaces;

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
    public string Type { get; }

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
    public List<ParameterBase> Parameters { get; }

    /// <summary>
    ///     Adds a parameter to the method.
    /// </summary>
    /// <param name="parameter"></param>
    public IMethod AddParameter(ParameterBase parameter);
}
