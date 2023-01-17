using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for documentation block parameters.
/// </summary>
public abstract class DocBlockParameterBase : IDocBlockParameter
{
    /// <summary>
    ///     Creates a new documentation block parameter.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    protected DocBlockParameterBase(string name, string? description)
    {
        Name = name;
        Description = description;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string? Description { get; }
}
