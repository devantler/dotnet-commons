namespace Devantler.Commons.CodeGen.CSharp.Templates;

/// <summary>
/// The template for a C# doc block parameter
/// </summary>
public static class CSharpDocBlockParameterTemplate
{
    /// <summary>
    /// Gets the doc block parameter template text
    /// </summary>
    public static string GetTemplate() => """<param name="{{ $1.name }}">{{ $1.description }}</param>""";
}
