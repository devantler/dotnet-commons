using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for methods.
/// </summary>
public abstract class MethodBase : IClassMember, IInterfaceMember
{
    /// <summary>
    /// The visibility of the method.
    /// </summary>
    public Visibility Visibility { get; }
    /// <summary>
    /// The name of the method.
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The return type of the method.
    /// </summary>
    public string ReturnType { get; }
    /// <summary>
    /// The body of the method.
    /// </summary>
    public string? Body { get; }
    /// <summary>
    /// The documentation block for the method.
    /// </summary>
    public DocumentationBlockBase? DocumentationBlock { get; }
    /// <summary>
    /// The parameters accepted by the method.
    /// </summary>
    public List<ParameterBase> Parameters { get; set; } = new List<ParameterBase>();

    /// <summary>
    /// Creates a new method.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="returnType"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    protected MethodBase(Visibility visibility, string returnType, string name, string? body = null, DocumentationBlockBase? documentationBlock = default)
    {
        Visibility = visibility;
        Name = name;
        ReturnType = returnType;
        Body = body;
        DocumentationBlock = documentationBlock;
    }

    /// <summary>
    /// Adds a parameter to the method.
    /// </summary>
    /// <param name="parameter"></param>
    public void AddParameter(ParameterBase parameter) => Parameters.Add(parameter);

    /// <summary>
    /// Compiles the method.
    /// </summary>
    public abstract string Compile();
}
