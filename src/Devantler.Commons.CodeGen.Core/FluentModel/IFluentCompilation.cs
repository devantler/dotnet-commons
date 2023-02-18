using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a compilation.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentCompilation<T> : ICompilation where T : ICompilation
{
    /// <summary>
    /// Adds a compilable type to the compilation.
    /// </summary>
    /// <param name="type"></param>
    public T AddType(IType type);
}
