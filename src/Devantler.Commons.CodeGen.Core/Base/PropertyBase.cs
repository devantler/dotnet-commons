using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for properties.
/// </summary>
public abstract class PropertyBase : IProperty
{
    /// <summary>
    ///     Creates a new property.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    protected PropertyBase(Visibility visibility, string type, string name, string? value = null)
    {
        Visibility = visibility;
        Type = type;
        Name = name;
        Value = value;
    }

    /// <summary>
    ///     The visibility of the property.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    ///     The type of the property.
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     The name of the property.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The value of the property.
    /// </summary>
    public string? Value { get; }

    /// <summary>
    ///     The documentation block for the property.
    /// </summary>
    public abstract DocBlockBase? DocBlock { get; }
}
