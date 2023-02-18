using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a field.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentField<T> : IField where T : IField
{
    /// <summary>
    ///     Sets the visibility of the field.
    /// </summary>
    public T SetVisibility(Visibility visibility);

    /// <summary>
    ///     Sets the value of the field.
    /// </summary>
    public T SetValue(string? value);

    /// <summary>
    ///     Sets the documentation block of the field.
    /// </summary>
    public T SetDocBlock(IDocBlock docBlock);
}
