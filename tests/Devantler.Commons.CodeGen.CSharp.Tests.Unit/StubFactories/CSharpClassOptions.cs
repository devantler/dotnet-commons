namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public class CSharpClassOptions : OptionsBase
{
    public int PropertiesCount { get; set; }
    public int MethodsCount { get; set; }
    public int ConstructorsCount { get; set; }
    public int FieldsCount { get; set; }
    public bool IncludeImplementation { get; set; }
}
