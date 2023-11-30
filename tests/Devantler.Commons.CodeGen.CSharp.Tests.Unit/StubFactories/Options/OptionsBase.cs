namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// Base class for options stubs.
/// </summary>
public class OptionsBase
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Should include using statements.
    /// </summary>
    public bool IncludeUsing { get; set; }
    /// <summary>
    /// Should include documentation.
    /// </summary>
    public bool IncludeDocumentation { get; set; }
    /// <summary>
    /// Should include namespace.
    /// </summary>
    public bool IncludeNamespace { get; set; }
}
