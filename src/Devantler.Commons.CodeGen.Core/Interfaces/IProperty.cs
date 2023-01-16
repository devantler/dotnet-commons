using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a property.
/// </summary>
public interface IProperty
{
    /// <summary>
    /// The visibility of the property.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    /// The type of the property.
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// The name of the property.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The value of the property.
    /// </summary>
    public string? Value { get; }

    /// <summary>
    /// The documentation block for the property.
    /// </summary>
    public DocBlockBase? DocBlock { get; }
}
