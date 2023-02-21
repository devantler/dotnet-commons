namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a interface.
/// </summary>
public interface IInterface : IType
{
    /// <summary>
    ///     The properties on the interface.
    /// </summary>
    public List<IProperty> Properties { get; }

    /// <summary>
    ///     The methods provided by the interface.
    /// </summary>
    public List<IMethod> Methods { get; }

    /// <summary>
    ///    The interfaces implemented by the interface.
    /// </summary>
    public List<IInterface> Implementations { get; }
}
