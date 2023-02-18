using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a constructor.
/// </summary>
public interface IFluentConstructor<T> : IConstructor where T : IConstructor
{
    /// <summary>
    /// Adds a parameter to the constructor.
    /// </summary>
    /// <param name="parameter"></param>
    public T AddParameter(IConstructorParameter parameter);

    /// <summary>
    /// Sets the body of the constructor.
    /// </summary>
    /// <param name="body"></param>
    public T SetBody(string body);

    /// <summary>
    /// Sets the documentation block of the constructor.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);
}
