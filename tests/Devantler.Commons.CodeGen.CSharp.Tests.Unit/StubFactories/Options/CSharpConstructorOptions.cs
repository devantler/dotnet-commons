namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpConstructorOptions
{
    public int Count { get; set; }
    public bool IncludeStatement { get; set; }
    public bool IncludeDocumentation { get; set; }
    public CSharpConstructorParameterOptions ParameterOptions { get; set; } = new();
}
