using Devantler.Commons.AutoFixture.DataAttributes;
using Devantler.Commons.CodeGen.Core.TemplateLoaders;
using Scriban;
using Scriban.Parsing;

namespace Devantler.Commons.CodeGen.Core.Tests.Unit;

/// <summary>
/// Unit tests for the <see cref="FileTemplateLoader"/> class.
/// </summary>
public class FileTemplateLoaderTests
{
    /// <summary>
    /// Tests if the GetPath method returns a valid path when given a template name.
    /// </summary>
    /// <param name="context">The template context.</param>
    /// <param name="sourceSpan">The source span.</param>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void GetPath_GivenTemplateName_ReturnsValidPath(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();

        // Act
        string result = sut.GetPath(context, sourceSpan, "test-template.sbn");

        // Assert
        Assert.Equal($"{Directory.GetCurrentDirectory()}/templates/test-template.sbn", result);
    }

    /// <summary>
    /// Tests the Load method of the FileTemplateLoader class when given a valid path and ensures that it returns the contents of the file.
    /// </summary>
    /// <param name="context">The template context to use for loading the file.</param>
    /// <param name="sourceSpan">The source span to use for loading the file.</param>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void Load_GivenValidPath_ReturnsFileContents(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/test-template.sbn";

        // Act
        string result = sut.Load(context, sourceSpan, path);

        // Assert
        Assert.Equal("This is a test template.", result);
    }

    /// <summary>
    /// Tests that an exception is thrown when attempting to load a template from an invalid file path.
    /// </summary>
    /// <param name="context">The template context.</param>
    /// <param name="sourceSpan">The source span.</param>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void Load_GivenInvalidPath_ThrowsFileNotFoundException(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/invalid-template.sbn";

        // Act
        void action() => sut.Load(context, sourceSpan, path);

        // Assert
        _ = Assert.Throws<FileNotFoundException>(action);
    }

    /// <summary>
    /// Tests that LoadAsync returns the contents of the file when given a valid path.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="sourceSpan"></param>
    /// <returns></returns>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public async Task LoadAsync_GivenValidPath_ReturnsFileContents(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/test-template.sbn";

        // Act
        string result = await sut.LoadAsync(context, sourceSpan, path);

        // Assert
        Assert.Equal("This is a test template.", result);
    }

    /// <summary>
    /// Tests that LoadAsync throws a FileNotFoundException when given an invalid path.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="sourceSpan"></param>
    /// <returns></returns>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public async Task LoadAsync_GivenInvalidPath_ThrowsFileNotFoundException(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/invalid-template.sbn";

        // Act
        async Task action() => await sut.LoadAsync(context, sourceSpan, path);

        // Assert
        _ = await Assert.ThrowsAsync<FileNotFoundException>(action);
    }
}
