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
        _ = result.Should().Be($"{Directory.GetCurrentDirectory()}/templates/test-template.sbn");
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
        _ = result.Should().Be("This is a test template.");
    }

    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void Load_GivenInvalidPath_ThrowsFileNotFoundException(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/invalid-template.sbn";

        // Act
        Action action = () => sut.Load(context, sourceSpan, path);

        // Assert
        _ = action.Should().Throw<FileNotFoundException>();
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
        _ = result.Should().Be("This is a test template.");
    }

    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public void LoadAsync_GivenInvalidPath_ThrowsFileNotFoundException(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new FileTemplateLoader();
        string path = $"{Directory.GetCurrentDirectory()}/templates/invalid-template.sbn";

        // Act
        Func<Task> action = async () => await sut.LoadAsync(context, sourceSpan, path);

        // Assert
        _ = action.Should().ThrowAsync<FileNotFoundException>();
    }
}
