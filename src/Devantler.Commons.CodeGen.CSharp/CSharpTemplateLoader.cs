using Devantler.Commons.CodeGen.Core;
using Scriban;
using Scriban.Parsing;

namespace Devantler.Commons.CodeGen.CSharp;

/// <summary>
/// A template loader that loads C# templates from memory.
/// </summary>
public class CSharpTemplateLoader : InMemoryTemplateLoaderBase
{
    /// <inheritdoc />
    public override string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName) =>
        $"Devantler.Commons.CodeGen.CSharp.Models.CSharp{templateName.ToPascalCase()}";

    /// <inheritdoc/>
    public override string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
    {
        var type = Type.GetType(templatePath);
        var property = type.GetProperty("Template");
        return (string)property.GetValue(type, null);
    }
}
