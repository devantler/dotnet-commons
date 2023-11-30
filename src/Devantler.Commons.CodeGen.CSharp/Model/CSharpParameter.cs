using Devantler.Commons.CodeGen.Core.FluentModel;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# parameter.
/// </summary>
/// <remarks>
/// Creates a new C# parameter.
/// </remarks>
/// <param name="type"></param>
/// <param name="name"></param>
public class CSharpParameter(string type, string name) : IFluentParameter<CSharpParameter>
{
    /// <inheritdoc/>
    public string Type { get; set; } = type;
    /// <inheritdoc/>
    public string Name { get; set; } = name;
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
