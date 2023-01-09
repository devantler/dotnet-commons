namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPascalCaseTests
{
    [Fact]
    public void ToPascalCase_GivenSingleWord_ReturnsPascalCase()
    {
        const string TEXT = "test";
        const string expected = "Test";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_GivenMultipleWords_ReturnsPascalCase()
    {
        const string TEXT = "this is a test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_GivenCamelCase_ReturnsPascalCase()
    {
        const string TEXT = "thisIsATest";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_GivenSnakeCase_ReturnsPascalCase()
    {
        const string TEXT = "this_is_a_test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_GivenKebabCase_ReturnsPascalCase()
    {
        const string TEXT = "this-is-a-test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }
}
