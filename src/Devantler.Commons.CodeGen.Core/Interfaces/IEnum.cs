namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
///     An interface representing an enumeration.
/// </summary>
public interface IEnum : IType<IEnum>
{
    /// <summary>
    ///     The values of the enum.
    /// </summary>
    public List<IEnumValue> Values { get; }

    /// <summary>
    ///     Adds a value to the enum.
    /// </summary>
    /// <param name="value"></param>
    public IEnum AddValue(IEnumValue value);
}
