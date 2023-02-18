using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for an enumeration.
/// </summary>
public interface IFluentEnum<T> : IEnum, IFluentType<T> where T : IEnum
{
    /// <summary>
    ///     Adds a value to the enum.
    /// </summary>
    /// <param name="value"></param>
    public T AddValue(IEnumValue value);
}
