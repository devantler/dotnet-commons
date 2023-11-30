namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# implementation options stub.
/// </summary>
public class CSharpImplementationOptions
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Property options.
    /// </summary>
    public CSharpPropertyOptionsBase PropertyOptions { get; set; } = new();
}
