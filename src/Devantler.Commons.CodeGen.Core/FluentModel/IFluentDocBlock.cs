using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a documentation block.
/// </summary>
public interface IFluentDocBlock<T> : IDocBlock where T : IDocBlock
{
    /// <summary>
    ///     Adds a parameter to the documentation block.
    /// </summary>
    /// <param name="parameter"></param>
    public T AddParameter(IDocBlockParameter parameter);
}
