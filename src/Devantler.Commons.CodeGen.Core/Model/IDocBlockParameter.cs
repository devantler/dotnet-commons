namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a parameter in a documentation block.
/// </summary>
public interface IDocBlockParameter
{
    /// <summary>
    ///     The name of the parameter.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The description of the parameter.
    /// </summary>
    public string? Description { get; }
}
