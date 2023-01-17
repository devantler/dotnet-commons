using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for fields.
/// </summary>
public abstract class FieldBase : IField
{
    /// <summary>
    ///     Creates a new field.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    protected FieldBase(Visibility visibility, string type, string name, string? value = null)
    {
        Visibility = visibility;
        Type = type;
        Name = name;
        Value = value;
    }

    /// <summary>
    ///     The visibility of the field.
    /// </summary>
    public Visibility Visibility { get; }

    /// <summary>
    ///     The type of the field.
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     The name of the field.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The value of the field.
    /// </summary>
    public string? Value { get; }

    /// <summary>
    ///     The documentation block for the field.
    /// </summary>
    public abstract DocBlockBase? DocBlock { get; }
}
