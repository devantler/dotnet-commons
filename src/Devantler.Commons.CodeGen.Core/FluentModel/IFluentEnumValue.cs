using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for an enum value.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentEnumValue<T> : IEnumValue where T : IEnumValue
{
    /// <summary>
    /// Sets the value of the enum value.
    /// </summary>
    /// <param name="value"></param>
    public T SetValue(int value);
    /// <summary>
    /// Sets the value of the enum value.
    /// </summary>
    /// <param name="value"></param>
    public T SetValue(string value);
    /// <summary>
    /// Sets the value of the enum value.
    /// </summary>
    /// <param name="value"></param>
    public T SetValue(Enum value);
    /// <summary>
    /// Sets the documentation block of the enum value.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);
}
