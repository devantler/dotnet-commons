using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for code collections.
/// </summary>
public abstract class CodeCollectionBase : ICodeCollection
{
    /// <summary>
    /// A list of compilable units in the code collection.
    /// </summary>
    public List<ICompilableUnit> CompilableUnits { get; set; } = new List<ICompilableUnit>();
    /// <inheritdoc/>
    public void AddCompilableUnit(ICompilableUnit compilableUnit) => CompilableUnits.Add(compilableUnit);
    /// <inheritdoc/>
    public Dictionary<string, string> Compile()
    {
        var result = new Dictionary<string, string>();

        if (!CompilableUnits.Any())
            throw new InvalidOperationException("No compilable units found in the code collection.");

        foreach (ICompilableUnit unit in CompilableUnits)
        {
            result.Add(unit.Name, unit.Compile().TrimStart(Environment.NewLine.ToCharArray()));
        }

        return result;
    }
}
