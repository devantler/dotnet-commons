using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a property.
/// </summary>
public interface IFluentProperty<T> : IProperty where T : IProperty
{
    /// <summary>
    /// Sets the visibility of the property.
    /// </summary>
    /// <param name="visibility"></param>
    public T SetVisibility(Visibility visibility);

    /// <summary>
    /// Sets the value of the property.
    /// </summary>
    /// <param name="value"></param>
    public T SetValue(string value);

    /// <summary>
    /// Sets the documentation block of the property.
    /// </summary>
    /// <param name="docBlock"></param>
    public T SetDocBlock(IDocBlock docBlock);
}
