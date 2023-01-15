namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a code base.
/// </summary>
public interface ICodeCollection
{
    /// <summary>
    /// Adds a compilable unit to the code base.
    /// </summary>
    /// <param name="compilableUnit"></param>
    public void AddCompilableUnit(ICompilableUnit compilableUnit);
    /// <summary>
    /// Compiles the code base.
    /// </summary>
    public Dictionary<string, string> Compile();
}
