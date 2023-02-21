namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a value in an enum.
/// </summary>
public interface IEnumValue
{
    /// <summary>
    ///     The name of the value.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The value of the enum.
    /// </summary>
    public string? Value { get; }

    /// <summary>
    /// The documentation block of the enum value.
    /// </summary>
    public IDocBlock? DocBlock { get; }
}
