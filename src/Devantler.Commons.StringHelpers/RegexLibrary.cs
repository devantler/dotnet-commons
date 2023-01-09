using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static class RegexLibrary
{
    public static Regex CamelCaseRegex { get; set; } = new Regex("([a-z])([A-Z])");
    public static Regex MultipleDashesRegex { get; set; } = new Regex("-{2,}");
    public static Regex NonAlphanumericRegex { get; set; } = new Regex("[^a-zA-Z0-9]");
    public static Regex SpaceRegex { get; set; } = new Regex(@"\s+");
    public static Regex TrailingDashesRegex { get; set; } = new Regex("-+$");
    public static Regex WordsRegex { get; set; } = new Regex("[A-Z][a-z]+|[a-z]+|[A-Z]");
    public static Regex PascalCaseRegex { get; set; } = new Regex("([A-Z])([A-Z][a-z])");
}
