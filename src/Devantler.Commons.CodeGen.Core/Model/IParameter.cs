namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a parameter in a method.
/// </summary>
public interface IParameter
{
    /// <summary>
    ///     The type of the parameter.
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     The name of the parameter.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The default value of the parameter.
    /// </summary>
    public string DefaultValue { get; }

    /// <summary>
    /// If the parameter is nullable or not.
    /// </summary>
    public bool IsNullable { get; set; }
}
