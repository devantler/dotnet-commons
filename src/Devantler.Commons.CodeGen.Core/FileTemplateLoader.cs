using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.Core;

/// <summary>
///     A very simple ITemplateLoader loading directly from the disk, without any checks...etc.
/// </summary>
public class FileTemplateLoader : ITemplateLoader
{
    /// <inheritdoc />
    public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName) =>
        Path.Combine($"{Directory.GetCurrentDirectory()}/templates", templateName);

    /// <inheritdoc />
    public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath) =>
        !File.Exists(templatePath)
            ? throw new FileNotFoundException($"Template file not found at path: {templatePath}")
            : File.ReadAllText(templatePath);

    /// <inheritdoc />
    public async ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath) =>
        !File.Exists(templatePath)
            ? throw new FileNotFoundException($"Template file not found at path: {templatePath}")
            : await File.ReadAllTextAsync(templatePath);
}
