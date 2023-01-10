namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToKebabCaseTests
{
    [Theory]
    [InlineData("this-is-a-test")]
    [InlineData("this_is_a_test")]
    [InlineData("THIS_IS_A_TEST")]
    [InlineData("THIS-IS-A-TEST")]
    [InlineData("This is a test")]
    [InlineData("ThisIsATest")]
    [InlineData("thisIsATest")]
    public void ReturnsKebabCase(string text)
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = text.ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }
}
