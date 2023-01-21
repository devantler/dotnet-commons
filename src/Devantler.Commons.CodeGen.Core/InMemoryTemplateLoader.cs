using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.Core;

/// <summary>
/// A template loader that loads templates from memory.
/// </summary>
public abstract class InMemoryTemplateLoaderBase : ITemplateLoader
{
    /// <summary>
    /// Gets the namespace for a template.
    /// </summary>
    /// <remarks>
    /// You need to return the namespace for the type that contains a property or a method that returns the template text.
    /// An example return value could be <c>$"Devantler.Commons.CodeGen.CSharp.Templates.CSharp{templateName.ToPascalCase()}Template</c>";
    /// </remarks>
    /// <param name="context"></param>
    /// <param name="callerSpan"></param>
    /// <param name="templateName"></param>
    public abstract string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName);

    /// <summary>
    /// Loads a template from memory through reflection.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="callerSpan"></param>
    /// <param name="templatePath"></param>
    public abstract string Load(TemplateContext context, SourceSpan callerSpan, string templatePath);

    /// <summary>
    /// Loads a template from memory through reflection.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="callerSpan"></param>
    /// <param name="templatePath"></param>
    public ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath) =>
        new(Load(context, callerSpan, templatePath));
}
