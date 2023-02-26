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
    /// Adds a statement to the constructor.
    /// </summary>
    /// <param name="statement"></param>
    public T AddStatement(string statement);

    /// <summary>
    /// Sets the documentation block of the constructor.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);

    /// <summary>
    /// Sets the visibility of the constructor.
    /// </summary>
    /// <param name="visibility"></param>
    public T SetVisibility(Visibility visibility);
}
