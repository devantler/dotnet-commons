using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

/// <summary>
/// C# interface options stub.
/// </summary>
public class CSharpInterfaceOptions : OptionsBase
{
    /// <summary>
    /// Interface visibility.
    /// </summary>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <summary>
    /// Should be partial.
    /// </summary>
    public bool IsPartial { get; set; }
    /// <summary>
    /// Property options.
    /// </summary>
    public CSharpInterfacePropertyOptions PropertyOptions { get; set; } = new();
    /// <summary>
    /// Method options.
    /// </summary>
    public CSharpMethodOptions MethodOptions { get; set; } = new();
    /// <summary>
    /// Implementation options.
    /// </summary>
    public CSharpImplementationOptions ImplementationOptions { get; set; } = new();
}
