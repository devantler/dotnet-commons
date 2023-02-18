using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a method.
/// </summary>
public interface IFluentMethod<T> : IMethod where T : IMethod
{
    /// <summary>
    /// Adds a parameter to the method.
    /// </summary>
    /// <param name="parameter"></param>
    public T AddParameter(IParameter parameter);

    /// <summary>
    /// Sets the body of the method.
    /// </summary>
    /// <param name="body"></param>
    public T SetBody(string body);

    /// <summary>
    /// Sets the documentation block of the method.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);
}
