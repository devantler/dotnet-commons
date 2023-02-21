using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpFieldOptions
{
    public int Count { get; set; }
    public bool IncludeDocumentation { get; set; }
    public Visibility Visibility { get; set; } = Visibility.Public;
    public bool IncludeValue { get; set; }
    public bool Nullables { get; set; }
}
