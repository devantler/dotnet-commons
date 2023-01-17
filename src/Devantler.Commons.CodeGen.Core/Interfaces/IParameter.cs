namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
///     An interface representing a parameter in a method.
/// </summary>
public interface IParameter
{
    /// <summary>
    ///     The type of the parameter.
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     The name of the parameter.
    /// </summary>
    public string Name { get; }
}
