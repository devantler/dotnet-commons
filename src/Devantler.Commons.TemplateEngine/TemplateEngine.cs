namespace Devantler.Commons.TemplateEngine;


/// <summary>
/// Represents a template engine that can render templates from a file path or from content.
/// </summary>
public class TemplateEngine : ITemplateEngine
{
  /// <summary>
  /// Renders a template from a file path asynchronously.
  /// </summary>
  /// <param name="templatePath">The path to the template file.</param>
  /// <param name="model">The model object to use for rendering the template.</param>
  /// <returns>A task that represents the asynchronous rendering operation. The task result contains the rendered template as a string.</returns>
  public async Task<string> RenderFromPathAsync(string templatePath, object model)
  {
    string templateFile = await File.ReadAllTextAsync(templatePath);
    var parsedTemplate = Scriban.Template.Parse(templateFile);
    return await parsedTemplate.RenderAsync(model);
  }

  /// <summary>
  /// Renders a template from content asynchronously.
  /// </summary>
  /// <param name="templateContent">The content of the template.</param>
  /// <param name="model">The model object to use for rendering the template.</param>
  /// <returns>A task that represents the asynchronous rendering operation. The task result contains the rendered template as a string.</returns>
  public async Task<string> RenderFromContentAsync(string templateContent, object model)
  {
    var parsedTemplate = Scriban.Template.Parse(templateContent);
    return await parsedTemplate.RenderAsync(model);
  }
}
