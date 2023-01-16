namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a class.
/// </summary>
public interface IClass : IType<IClass>
{
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

    /// <summary>
    /// Adds a field to the class.
    /// </summary>
    /// <param name="field"></param>
    public IClass AddField(IField field);

    /// <summary>
    /// Adds a property to the class.
    /// </summary>
    /// <param name="property"></param>
    public IClass AddProperty(IProperty property);

    /// <summary>
    /// Adds a constructor to the class.
    /// </summary>
    /// <param name="constructor"></param>
    public IClass AddConstructor(IConstructor constructor);

    /// <summary>
    /// Adds a method to the class.
    /// </summary>
    /// <param name="method"></param>
    public IClass AddMethod(IMethod method);
}
