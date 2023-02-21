namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpImplementationOptions
{
    public int Count { get; set; }
    public CSharpPropertyOptionsBase PropertyOptions { get; set; } = new();
}
