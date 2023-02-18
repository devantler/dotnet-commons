using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing Fluent functionality for a documentation block parameter.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentDocBlockParameter<T> : IDocBlockParameter where T : IDocBlockParameter
{
    /// <summary>
    /// Adds a parameter to the documentation block.
    /// </summary>
    /// <param name="description"></param>
    public T SetDescription(string description);
}
