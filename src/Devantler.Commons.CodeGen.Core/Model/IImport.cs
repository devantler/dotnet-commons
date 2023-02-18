namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing an import.
/// </summary>
public interface IImport
{
    /// <summary>
    ///     The name of the import.
    /// </summary>
    string Name { get; }

    /// <summary>
    ///     The alias of the import.
    /// </summary>
    string? Alias { get; }
}
