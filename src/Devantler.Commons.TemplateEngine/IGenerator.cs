namespace Devantler.Commons.TemplateEngine;

/// <summary>
/// Represents a generator that can generate files or string outputs based on templates and models.
/// </summary>
public interface IGenerator
{
  /// <summary>
  /// Generates a file asynchronously based on a template and a model.
  /// </summary>
  /// <param name="outputPath">The path where the generated file will be saved.</param>
  /// <param name="templatePath">The path to the template file.</param>
  /// <param name="model">The model object used for generating the file.</param>
  /// <param name="fileMode">The file mode used when creating the file. Default is FileMode.CreateNew.</param>
  /// <returns>A task representing the asynchronous operation.</returns>
  Task GenerateAsync(string outputPath, string templatePath, object model, FileMode fileMode = FileMode.CreateNew);

  /// <summary>
  /// Generates a string output based on the specified template and model asynchronously.
  /// </summary>
  /// <param name="templatePath">The path to the template file.</param>
  /// <param name="model">The model object used to populate the template.</param>
  /// <returns>A task representing the asynchronous operation. The task result contains the generated string output.</returns>
  Task<string> GenerateAsync(string templatePath, object model);
}
