using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

public class CSharpClassOptions : OptionsBase
{
    public bool IncludeBaseClass { get; set; }
    public Visibility Visibility { get; set; } = Visibility.Public;
    public bool IsPartial { get; set; }
    public bool IsAbstract { get; set; }
    public bool IsStatic { get; set; }
    public CSharpFieldOptions FieldOptions { get; set; } = new();
    public CSharpClassPropertyOptions PropertyOptions { get; set; } = new();
    public CSharpMethodOptions MethodOptions { get; set; } = new();
    public CSharpConstructorOptions ConstructorOptions { get; set; } = new();
    public CSharpImplementationOptions ImplementationOptions { get; set; } = new();
}
