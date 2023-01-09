namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToCamelCaseTests
{
    [Fact]
    public void ToCamelCase_GivenSingleWord_ReturnsCamelCase()
    {
        const string TEXT = "test";
        const string expected = "test";
        string actual = TEXT.ToCamelCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToCamelCase_GivenMultipleWords_ReturnsCamelCase()
    {
        const string TEXT = "this is a test";
        const string expected = "thisIsATest";
        string actual = TEXT.ToCamelCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToCamelCase_GivenPascalCase_ReturnsCamelCase()
    {
        const string TEXT = "ThisIsATest";
        const string expected = "thisIsATest";
        string actual = TEXT.ToCamelCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToCamelCase_GivenSnakeCase_ReturnsCamelCase()
    {
        const string TEXT = "this_is_a_test";
        const string expected = "thisIsATest";
        string actual = TEXT.ToCamelCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToCamelCase_GivenKebabCase_ReturnsCamelCase()
    {
        const string TEXT = "this-is-a-test";
        const string expected = "thisIsATest";
        string actual = TEXT.ToCamelCase();
        _ = expected.Should().Be(actual);
    }
}
