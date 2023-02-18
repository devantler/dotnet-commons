namespace Devantler.Commons.CodeGen.Core.Model;

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
}
