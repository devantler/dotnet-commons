namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
/// An interface representing a class.
/// </summary>
public interface IClass : IType
{
    /// <summary>
    /// The base class implemented by the class.
    /// </summary>
    public IClass? BaseClass { get; set; }
    /// <summary>
    /// The implemented interfaces.
    /// </summary>
    public List<IInterface> Implementations { get; }
    /// <summary>
    /// The fields on the class.
    /// </summary>
    public List<IField> Fields { get; }

    /// <summary>
    /// The properties on the class.
    /// </summary>
    public List<IProperty> Properties { get; }

    /// <summary>
    /// The constructors for the class.
    /// </summary>
    public List<IConstructor> Constructors { get; }

    /// <summary>
    /// The methods provided by the class.
    /// </summary>
    public List<IMethod> Methods { get; }
}
