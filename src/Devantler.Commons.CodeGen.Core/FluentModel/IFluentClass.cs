using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a class.
/// </summary>
public interface IFluentClass<T> : IClass, IFluentType<T> where T : IClass
{
    /// <summary>
    /// Sets the base class of the class.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public T SetBaseClass(T? @class);

    /// <summary>
    /// Sets whether the class is a static class or not.
    /// </summary>
    /// <param name="isStatic"></param>
    public T SetIsStatic(bool isStatic);

    /// <summary>
    /// Sets whether the class is an abstract class or not.
    /// </summary>
    /// <param name="isAbstract"></param>
    public T SetIsAbstract(bool isAbstract);

    /// <summary>
    /// Adds an implementation to the class.
    /// </summary>
    /// <param name="implementation"></param>
    /// <returns></returns>
    public T AddImplementation(IInterface implementation);

    /// <summary>
    ///     Adds a field to the class.
    /// </summary>
    /// <param name="field"></param>
    public T AddField(IField field);

    /// <summary>
    ///     Adds a property to the class.
    /// </summary>
    /// <param name="property"></param>
    public T AddProperty(IProperty property);

    /// <summary>
    ///     Adds a constructor to the class.
    /// </summary>
    /// <param name="constructor"></param>
    public T AddConstructor(IConstructor constructor);

    /// <summary>
    ///     Adds a method to the class.
    /// </summary>
    /// <param name="method"></param>
    public T AddMethod(IMethod method);
}
