namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
/// An interface representing a constructor parameter.
/// </summary>
public interface IConstructorParameter : IParameter
{
    /// <summary>
    /// Whether the parameter is a base parameter.
    /// </summary>
    public bool IsBaseParameter { get; set; }
}
