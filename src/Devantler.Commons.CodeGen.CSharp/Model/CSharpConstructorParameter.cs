using Devantler.Commons.CodeGen.Core.FluentModel;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# parameter.
/// </summary>
public class CSharpConstructorParameter : IFluentConstructorParameter<CSharpConstructorParameter>
{
    /// <summary>
    /// Creates a new C# parameter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    public CSharpConstructorParameter(string type, string name)
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
    /// <inheritdoc/>
    public bool IsNullable { get; set; }
    /// <inheritdoc/>
    public CSharpConstructorParameter SetIsBaseParameter(bool isBaseParameter)
    {
        IsBaseParameter = isBaseParameter;
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructorParameter SetIsNullable(bool isNullable)
    {
        IsNullable = isNullable;
        return this;
    }
    /// <summary>
    /// The template for a C# parameter.
    /// </summary>
    public static string Template => """{{ parameter.type }}{{ parameter.is_nullable ? "?" : "" }} {{ parameter.name }}""";

}
