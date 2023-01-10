namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPascalCaseTests
{
    [Theory]
    [InlineData("this-is-a-test")]
    [InlineData("this_is_a_test")]
    [InlineData("THIS_IS_A_TEST")]
    [InlineData("THIS-IS-A-TEST")]
    [InlineData("This is a test")]
    [InlineData("ThisIsATest")]
    [InlineData("thisIsATest")]
    public void ReturnsToPascalCase(string text)
    {
        //Arrange
        const string expected = "ThisIsATest";

        //Act
        string actual = text.ToPascalCase();

        //Assert
        _ = actual.Should().Be(expected);
    }
}
