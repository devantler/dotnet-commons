using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a type.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentType<T> : IType
{
    /// <summary>
    /// Sets the namespace of the type.
    /// </summary>
    public T SetNamespace(string? @namespace);

    /// <summary>
    /// Sets the documentation block of the type.
    /// </summary>
    public T SetDocBlock(IDocBlock docBlock);

    /// <summary>
    ///     Adds an import to the type.
    /// </summary>
    /// <param name="import"></param>
    public T AddImport(IImport import);
}
