using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing fluent functionality for a parameter.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentParameter<out T> : IParameter where T : IParameter
{
    /// <summary>
    /// Sets if the parameter is nullable or not.
    /// </summary>
    /// <param name="isNullable"></param>
    public T SetIsNullable(bool isNullable);

    /// <summary>
    /// Sets the default value for the parameter.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public T SetDefaultValue(string value);
}
