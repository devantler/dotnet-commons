using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for parameters.
/// </summary>
public abstract class ParameterBase : IParameter
{
    /// <summary>
    ///     Creates a new parameter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    protected ParameterBase(string type, string name)
    {
        Type = type;
        Name = name;
    }

    /// <summary>
    ///     The type of the parameter.
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     The name of the parameter.
    /// </summary>
    public string Name { get; }
}
