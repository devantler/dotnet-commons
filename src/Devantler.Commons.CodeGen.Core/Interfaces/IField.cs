using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a field.
/// </summary>
public interface IField
{
    /// <summary>
    /// The visibility of the field.
    /// </summary>
    public Visibility Visibility { get; }
    /// <summary>
    /// The type of the field.
    /// </summary>
    public string Type { get; }
    /// <summary>
    /// The name of the field.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The value of the field.
    /// </summary>
    public string? Value { get; }
    /// <summary>
    /// The documentation block for the field.
    /// </summary>
    public abstract DocBlockBase? DocBlock { get; }
}
