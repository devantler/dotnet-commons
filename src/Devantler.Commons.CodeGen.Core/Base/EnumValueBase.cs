using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for enum values.
/// </summary>
public abstract class EnumValueBase : IEnumValue
{
    /// <summary>
    ///     Creates a new enum value.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    protected EnumValueBase(string name, string value)
    {
        Name = name;
        Value = value;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string Value { get; }
}
