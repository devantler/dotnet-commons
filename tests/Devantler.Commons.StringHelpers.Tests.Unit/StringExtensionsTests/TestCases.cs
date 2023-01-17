namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public static class TestCases
{
    public static IEnumerable<object[]> CasingTests =>
           new List<object[]>
           {
                new object[] { "kebab-case"},
                new object[] { "camelCase"},
                new object[] { "UPPER_SNAKE_CASE"},
                new object[] { "lower_snake_case"},
                new object[] { "lower-train-case"},
                new object[] { "UPPER-TRAIN-CASE"},
                new object[] { "PascalCase"},
                new object[] { "PascalCaseWithDigits123"},
                new object[] { "Title Case"}
           };
}
