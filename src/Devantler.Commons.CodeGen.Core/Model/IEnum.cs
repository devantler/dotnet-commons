namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing an enumeration.
/// </summary>
public interface IEnum : IType
{
    /// <summary>
    ///     The values of the enum.
    /// </summary>
    public List<IEnumValue> Values { get; }
}
