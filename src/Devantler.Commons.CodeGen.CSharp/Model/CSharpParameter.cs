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
    public bool IsNullable { get; set; }
    /// <inheritdoc/>
    public string? DefaultValue { get; set; }
    /// <inheritdoc/>
    public CSharpParameter SetIsNullable(bool isNullable)
    {
        IsNullable = isNullable;
        return this;
    }
    /// <inheritdoc/>
    public CSharpParameter SetDefaultValue(string value)
    {
        DefaultValue = value;
        return this;
    }

    /// <summary>
    /// The template for a C# parameter.
    /// </summary>
    public static string Template => """{{ parameter.type }}{{ parameter.is_nullable ? "?" : "" }} {{ parameter.name }}{{ parameter.default_value ? " = " + parameter.default_value : ""}}""";
}
