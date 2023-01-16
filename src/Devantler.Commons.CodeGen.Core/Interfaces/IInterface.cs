namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a interface.
/// </summary>
public interface IInterface : IType<IInterface>
{
    /// <summary>
    /// The properties on the interface.
    /// </summary>
    public List<IProperty> Properties { get; }

    /// <summary>
    /// The methods provided by the interface.
    /// </summary>
    public List<IMethod> Methods { get; }

    /// <summary>
    /// Adds a property to the interface.
    /// </summary>
    /// <param name="property"></param>
    public IInterface AddProperty(IProperty property);

    /// <summary>
    /// Adds a method to the interface.
    /// </summary>
    /// <param name="method"></param>
    public IInterface AddMethod(IMethod method);
}
