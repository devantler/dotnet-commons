using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for imports.
/// </summary>
public abstract class ImportBase : IImport
{
    /// <inheritdoc/>
    public string Name { get; }

    /// <inheritdoc/>
    public string? Alias { get; }

    /// <summary>
    /// Creates a new import.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="alias"></param>
    protected ImportBase(string name, string? alias = null)
    {
        Name = name;
        Alias = alias;
    }
}
