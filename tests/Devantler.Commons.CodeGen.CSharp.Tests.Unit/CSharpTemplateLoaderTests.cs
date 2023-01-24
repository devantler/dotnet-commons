using Devantler.Commons.AutoFixture.DataAttributes;
using Devantler.Commons.CodeGen.CSharp.Models;
using Scriban;
using Scriban.Parsing;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

public class CSharpTemplateLoaderTests
{
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public async Task LoadAsync_GivenValidTemplateObjectPath_LoadsATemplateAsync(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new CSharpTemplateLoader();

        // Act
        string template = await sut.LoadAsync(context, sourceSpan, typeof(CSharpClass).FullName ?? string.Empty);

        // Assert
        _ = template.Should().NotBeEmpty();
    }

}
