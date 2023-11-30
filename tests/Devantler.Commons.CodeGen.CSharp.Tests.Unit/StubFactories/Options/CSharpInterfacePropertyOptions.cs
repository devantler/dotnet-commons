namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# interface property options stub.
/// </summary>
public class CSharpInterfacePropertyOptions : CSharpPropertyOptionsBase
{
    /// <summary>
    /// Should include value.
    /// </summary>
    public bool IncludeValue { get; set; }
    /// <summary>
    /// Should be an expression bodied property.
    /// </summary>
    public bool IsExpressionBodiedMembers { get; set; }
}
