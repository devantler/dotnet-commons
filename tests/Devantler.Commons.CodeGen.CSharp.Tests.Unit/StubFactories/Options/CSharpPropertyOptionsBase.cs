using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// Base class for C# property options stubs.
/// </summary>
public class CSharpPropertyOptionsBase
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Property visibility.
    /// </summary>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <summary>
    /// Should include documentation.
    /// </summary>
    public bool IncludeDocumentation { get; set; }
    /// <summary>
    /// Should include nullables.
    /// </summary>
    public bool Nullables { get; set; }
}
