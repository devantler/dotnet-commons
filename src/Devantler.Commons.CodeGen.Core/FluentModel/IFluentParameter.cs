using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core.FluentModel;

/// <summary>
/// An interface representing fluent functionality for a parameter.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFluentParameter<T> : IParameter where T : IParameter
{
}
