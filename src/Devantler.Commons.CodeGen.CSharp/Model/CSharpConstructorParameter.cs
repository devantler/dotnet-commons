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
public class CSharpConstructorParameter(string type, string name) : IFluentConstructorParameter<CSharpConstructorParameter>
{
    /// <inheritdoc/>
    public string Type { get; set; } = type;
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public bool IsBaseParameter { get; set; }
    /// <inheritdoc/>
    public bool IsNullable { get; set; }
    /// <inheritdoc/>
    public string? DefaultValue { get; set; }
    /// <summary>
    /// The name of the base parameter.
    /// </summary>
    public string? BaseParameterName { get; set; }
    /// <inheritdoc/>
    public CSharpConstructorParameter SetIsBaseParameter(bool isBaseParameter, string baseParameterName = "")
    {
        IsBaseParameter = isBaseParameter;
        BaseParameterName = !string.IsNullOrEmpty(baseParameterName) ? baseParameterName : Name;
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructorParameter SetIsNullable(bool isNullable)
    {
        IsNullable = isNullable;
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructorParameter SetDefaultValue(string value)
    {
        DefaultValue = value;
        return this;
    }

    /// <summary>
    /// The template for a C# parameter.
    /// </summary>
    public static string Template => """{{ parameter.type }}{{ parameter.is_nullable ? "?" : "" }} {{ parameter.name }}""";
}
