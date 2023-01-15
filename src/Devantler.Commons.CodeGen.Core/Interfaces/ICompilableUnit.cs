namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a compilable unit.
/// </summary>
public interface ICompilableUnit : ICompilable
{
    /// <summary>
    /// The name of the unit.
    /// </summary>
    public string Name { get; set; }
}
