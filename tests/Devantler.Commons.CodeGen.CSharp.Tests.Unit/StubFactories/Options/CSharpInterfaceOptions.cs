using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpInterfaceOptions : OptionsBase
{
    public Visibility Visibility { get; set; } = Visibility.Public;
    public bool IsPartial { get; set; }
    public CSharpInterfacePropertyOptions PropertyOptions { get; set; } = new();
    public CSharpMethodOptions MethodOptions { get; set; } = new();
    public CSharpImplementationOptions ImplementationOptions { get; set; } = new();
}
