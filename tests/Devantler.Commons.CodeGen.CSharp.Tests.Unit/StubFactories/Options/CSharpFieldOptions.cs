using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# field options stub.
/// </summary>
public class CSharpFieldOptions
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Should include documentation.
    /// </summary>
    public bool IncludeDocumentation { get; set; }
    /// <summary>
    /// Field visibility.
    /// </summary>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <summary>
    /// Should include value.
    /// </summary>
    public bool IncludeValue { get; set; }
    /// <summary>
    /// Should include nullables.
    /// </summary>
    public bool Nullables { get; set; }
}
