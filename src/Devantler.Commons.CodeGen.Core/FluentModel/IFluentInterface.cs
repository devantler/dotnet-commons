using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for an interface.
/// </summary>
public interface IFluentInterface<T> : IInterface, IFluentType<T> where T : IInterface
{
    /// <summary>
    ///     Adds a property to the interface.
    /// </summary>
    /// <param name="property"></param>
    public T AddProperty(IProperty property);

    /// <summary>
    ///     Adds a method to the interface.
    /// </summary>
    /// <param name="method"></param>
    public T AddMethod(IMethod method);
}
