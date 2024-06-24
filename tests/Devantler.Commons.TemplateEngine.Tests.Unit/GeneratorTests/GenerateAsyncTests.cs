namespace Devantler.Commons.TemplateEngine.Tests;

/// <summary>
/// Contains unit tests for the <see cref="Generator.GenerateAsync(string, object)"/> and the <see cref="Generator.GenerateAsync(string, string, object, FileMode)"/>
/// </summary>
public class GenerateAsyncTests
{
  /// <summary>
  /// Tests the <see cref="Generator.GenerateAsync(string, object)"/> method to ensure that it renders the template correctly.
  /// </summary>
  [Fact]
  public async Task GenerateAsync_ShouldRenderTemplate()
  {
    // Arrange
    string templatePath = $"{AppDomain.CurrentDomain.BaseDirectory}/assets/templates/hello-template.txt";
    var model = new { Name = "World" };
    string expectedOutput = "Hello, World!\n";

    var templateEngine = new TemplateEngine();
    var generator = new Generator(templateEngine);

    // Act
    string result = await generator.GenerateAsync(templatePath, model);

    // Assert
    Assert.Equal(expectedOutput, result);
  }

  /// <summary>
  /// Tests the <see cref="Generator.GenerateAsync(string, string, object, FileMode)"/> method to ensure that it creates a file with the rendered template content.
  /// </summary>
  [Fact]
  public async Task GenerateAsync_ShouldCreateFileWithRenderedTemplateContent()
  {
    // Arrange
    string outputPath = "/tmp/hello.txt";
    string templatePath = $"{AppDomain.CurrentDomain.BaseDirectory}/assets/templates/hello-template.txt";
    var model = new { Name = "World" };
    string expectedOutput = "Hello, World!\n";

    var templateEngine = new TemplateEngine();
    var generator = new Generator(templateEngine);

    // Act
    await generator.GenerateAsync(outputPath, templatePath, model, FileMode.CreateNew);

    // Assert
    Assert.True(File.Exists(outputPath));
    string fileContent = await File.ReadAllTextAsync(outputPath);
    Assert.Equal(expectedOutput, fileContent);

    // Cleanup
    File.Delete(outputPath);
  }
}
