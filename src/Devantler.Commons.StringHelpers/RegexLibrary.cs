using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static class RegexLibrary
{
    public static Regex NonAlphanumericRegex { get; set; } = new Regex("[^a-zA-Z0-9]");
    public static Regex WhitespaceRegex { get; set; } = new Regex(@"\s+");
    public static Regex FromLowerCaseChangeRegex { get; set; } = new Regex("([a-z])([A-Z])");
    public static Regex FromUpperCaseChangeRegex { get; set; } = new Regex("([A-Z])([a-z])");
    public static Regex MultipleDashesRegex { get; set; } = new Regex("-{2,}");
    public static Regex MultipleUnderscoresRegex { get; set; } = new Regex("_{2,}");
    public static Regex TrailingDashesRegex { get; set; } = new Regex("-+$");
    public static Regex WordsRegex { get; set; } = new Regex(@"([A-ZÆØÅ][a-zæøå]+|[a-zæøå]+|(?<![^\W_])[A-ZÆØÅ]+(?![^\W_])|\B[A-ZÆØÅ]{3,}|[A-ZÆØÅ])");
    public static Regex CamelCaseRegex { get; set; } = new Regex("^[a-z]+(?:[A-Z][a-z]+)*$");
    public static Regex PascalCaseRegex { get; set; } = new Regex("^[A-Z][a-z]+(?:[A-Z][a-z]+)*$");
    public static Regex KebabCaseRegex { get; set; } = new Regex("^[a-z-]+$");
}
