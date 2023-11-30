namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# parameter options stub.
/// </summary>
public class CSharpParameterOptions
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Should include nullables.
    /// </summary>
    public bool Nullables { get; set; }
    /// <summary>
    /// Should include default values.
    /// </summary>
    public bool HasDefaultValue { get; set; }
}
