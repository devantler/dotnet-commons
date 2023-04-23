using Devantler.Commons.AutoFixture.DataAttributes;
using Devantler.Commons.CodeGen.Core.TemplateLoaders;
using Scriban;
using Scriban.Parsing;

namespace Devantler.Commons.CodeGen.Core.Tests.Unit;

public class FileTemplateLoaderTests
{
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

    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void LoadAsync_GivenInvalidPath_ThrowsFileNotFoundException(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/invalid-template.sbn";

        // Act
        async Task action() => await sut.LoadAsync(context, sourceSpan, path);

        // Assert
        _ = Assert.ThrowsAsync<FileNotFoundException>(action);
    }
}
