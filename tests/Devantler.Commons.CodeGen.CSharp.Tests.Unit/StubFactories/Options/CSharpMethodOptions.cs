using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpMethodOptions
{
    public int Count { get; set; }
    public Visibility Visibility { get; set; } = Visibility.Public;
    public string ReturnType { get; set; } = "string";
    public bool IncludeStatement { get; set; }
    public bool IncludeDocumentation { get; set; }
    public bool IncludeParameter { get; set; }
    public CSharpParameterOptions ParameterOptions { get; set; } = new();
    public bool IsPartial { get; set; }
    public bool IsExtensionMethod { get; set; }
    public bool IsStatic { get; set; }
}
