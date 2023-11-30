using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# method options stub.
/// </summary>
public class CSharpMethodOptions
{
    /// <summary>
    /// Count of generated items.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Method visibility.
    /// </summary>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <summary>
    /// Method return type.
    /// </summary>
    public string ReturnType { get; set; } = "string";
    /// <summary>
    /// Should include statements.
    /// </summary>
    public bool IncludeStatement { get; set; }
    /// <summary>
    /// Should include documentation.
    /// </summary>
    public bool IncludeDocumentation { get; set; }
    /// <summary>
    /// Should include a parameter.
    /// </summary>
    public bool IncludeParameter { get; set; }
    /// <summary>
    /// Parameter options.
    /// </summary>
    public CSharpParameterOptions ParameterOptions { get; set; } = new();
    /// <summary>
    /// Should be a partial method.
    /// </summary>
    public bool IsPartial { get; set; }
    /// <summary>
    /// Should be an extension method.
    /// </summary>
    public bool IsExtensionMethod { get; set; }
    /// <summary>
    /// Should be a static method.
    /// </summary>
    public bool IsStatic { get; set; }
    /// <summary>
    /// Should include attributes.
    /// </summary>
    public bool IncludeAttribute { get; set; }
    /// <summary>
    /// Should be an expression bodied method.
    /// </summary>
    public bool IsExpressionBodied { get; set; }
    /// <summary>
    /// Should be an asynchronous method.
    /// </summary>
    public bool IsAsynchronous { get; set; }
}
