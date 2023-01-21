namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# parameter
/// </summary>
public static class CSharpParameterTemplate
{
    /// <summary>
    /// Gets the parameter template text
    /// </summary>
    public static string GetTemplate() => """{{ parameter.type }} {{ parameter.name }}""";
}
