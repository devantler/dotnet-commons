namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
///     An interface representing a documentation block.
/// </summary>
public interface IDocBlock
{
    /// <summary>
    ///     The summary of the documented unit described by the documentation block.
    /// </summary>
    public string Summary { get; }

    /// <summary>
    ///     The documented parameters of the documented unit described by the documentation block.
    /// </summary>
    public List<IDocBlockParameter> Parameters { get; }

    /// <summary>
    ///     Adds a parameter to the documentation block.
    /// </summary>
    /// <param name="parameter"></param>
    public IDocBlock AddParameter(IDocBlockParameter parameter);
}
