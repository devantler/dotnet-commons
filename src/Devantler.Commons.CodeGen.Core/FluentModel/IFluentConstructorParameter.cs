using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a constructor parameter.
/// </summary>
public interface IFluentConstructorParameter<T> : IConstructorParameter, IFluentParameter<T> where T : IConstructorParameter
{
    /// <summary>
    /// Sets whether the parameter is a base parameter.
    /// </summary>
    /// <param name="isBaseParameter"></param>
    public T SetIsBaseParameter(bool isBaseParameter);
}
