using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for constructors.
/// </summary>
public abstract class ConstructorBase : IClassMember
{
    /// <summary>
    /// The visibility of the constructor.
    /// </summary>
    public Visibility Visibility { get; }
    /// <summary>
    /// The name of the constructor.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The statements in the constructor.
    /// </summary>
    public string? Body { get; }
    /// <summary>
    /// The documentation block describing the constructor.
    /// </summary>
    public DocumentationBlockBase? DocumentationBlock { get; }
    /// <summary>
    /// The parameters accepted by the constructor.
    /// </summary>
    public List<ParameterBase> Parameters { get; set; } = new List<ParameterBase>();

    /// <summary>
    /// Creates a new constructor.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    protected ConstructorBase(Visibility visibility, string name, string? body = default, DocumentationBlockBase? documentationBlock = default)
    {
        Visibility = visibility;
        Name = name;
        Body = body;
        DocumentationBlock = documentationBlock;
    }

    /// <summary>
    /// Adds a parameter to the constructor.
    /// </summary>
    /// <param name="parameter"></param>
    public void AddParameter(ParameterBase parameter) => Parameters.Add(parameter);

    /// <summary>
    /// Compiles the constructor.
    /// </summary>
    public abstract string Compile();
}
