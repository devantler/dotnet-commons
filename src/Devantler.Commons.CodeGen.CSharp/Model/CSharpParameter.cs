using Devantler.Commons.CodeGen.Core.FluentModel;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# parameter.
/// </summary>
public class CSharpParameter : IFluentParameter<CSharpParameter>
{
    /// <summary>
    /// Creates a new C# parameter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    public CSharpParameter(string type, string name)
    {
        Name = name;
        Type = type;
    }
    /// <inheritdoc/>
    public string Type { get; set; }
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public bool IsBaseParameter { get; set; }
    /// <summary>
    /// The template for a C# parameter.
    /// </summary>
    public static string Template => """{{ parameter.type }} {{ parameter.name }}""";

}
