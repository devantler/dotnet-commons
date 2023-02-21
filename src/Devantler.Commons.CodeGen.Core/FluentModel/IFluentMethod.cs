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
    /// Adds a statement to the body of the method.
    /// </summary>
    /// <remarks>
    /// The order of the statements is preserved. E.g. the first statement added will be the first statement in the body.
    /// </remarks>
    /// <param name="statement"></param>
    public T AddStatement(string statement);

    /// <summary>
    /// Sets the visibility of the method.
    /// </summary>
    /// <param name="visibility"></param>
    public T SetVisibility(Visibility visibility);

    /// <summary>
    /// Sets the documentation block of the method.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);

    /// <summary>
    /// Sets the override flag of the method.
    /// </summary>
    /// <param name="isOverride"></param>
    public T SetIsOverride(bool isOverride);

    /// <summary>
    /// Sets the static flag of the method.
    /// </summary>
    /// <param name="isStatic"></param>
    public T SetIsStatic(bool isStatic);

    /// <summary>
    /// Sets the return type of the method.
    /// </summary>
    /// <param name="returnType"></param>
    public T SetReturnType(string returnType);

}
