using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpEnumOptions : OptionsBase
{
    public CSharpEnumSymbolOptions EnumSymbolOptions { get; set; } = new();
    public Visibility Visibility { get; set; } = Visibility.Public;
}
