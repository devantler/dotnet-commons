using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for methods.
/// </summary>
public abstract class MethodBase : IMethod
{
    /// <summary>
    ///     Creates a new method.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="returnType"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    protected MethodBase(Visibility visibility, string returnType, string name, string? body = null,
        IDocBlock? documentationBlock = default)
    {
        Visibility = visibility;
        Name = name;
        Type = returnType;
        Body = body;
        DocBlock = documentationBlock;
    }

    /// <inheritdoc />
    public Visibility Visibility { get; }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string Type { get; }

    /// <inheritdoc />
    public string? Body { get; }

    /// <inheritdoc />
    public IDocBlock? DocBlock { get; }

    /// <inheritdoc />
    public List<ParameterBase> Parameters { get; set; } = new();

    /// <summary>
    ///     Adds a parameter to the method.
    /// </summary>
    /// <param name="parameter"></param>
    public IMethod AddParameter(ParameterBase parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
}
