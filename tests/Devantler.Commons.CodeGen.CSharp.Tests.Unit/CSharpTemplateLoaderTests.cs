using Devantler.Commons.AutoFixture.DataAttributes;
using Devantler.Commons.CodeGen.CSharp.Model;
using Scriban;
using Scriban.Parsing;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

/// <summary>
/// C# template loader tests.
/// </summary>
public class CSharpTemplateLoaderTests
{
    /// <summary>
    /// Tests the <see cref="CSharpTemplateLoader.Load"/> method.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="sourceSpan"></param>
    /// <returns></returns>
    [Theory, AutoNSubstituteData(typeof(SupportMutableValueTypesCustomization))]
    public async Task LoadAsync_GivenValidTemplateObjectPath_LoadsATemplateAsync(TemplateContext context, SourceSpan sourceSpan)
    {
        // Arrange
        var sut = new CSharpTemplateLoader();

        // Act
        string template = await sut.LoadAsync(context, sourceSpan, typeof(CSharpClass).FullName ?? string.Empty);

        // Assert
        Assert.NotEmpty(template);
    }
}
