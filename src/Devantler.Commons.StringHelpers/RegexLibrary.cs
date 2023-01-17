using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

/// <summary>
///     Static class that functions as a library of regular expressions.
/// </summary>
public static class RegexLibrary
{
    /// <summary>
    ///     Regex that matches non-alphanumeric characters.
    /// </summary>
    public static Regex NonAlphanumericRegex { get; set; } = new("[^a-zA-Z0-9]");

    /// <summary>
    ///     Regex that matches whitespace.
    /// </summary>
    public static Regex WhitespaceRegex { get; set; } = new(@"\s+");

    /// <summary>
    ///     Regex that matches change in casing from lower to upper, e.g., aB.
    /// </summary>
    public static Regex FromLowerCaseChangeRegex { get; set; } = new("([a-z])([A-Z])");

    /// <summary>
    ///     Regex that matches change in casing from upper to lower, e.g., Ba.
    /// </summary>
    public static Regex FromUpperCaseChangeRegex { get; set; } = new("([A-Z])([a-z])");

    /// <summary>
    ///     Regex that matches consecutive dashes.
    /// </summary>
    public static Regex MultipleDashesRegex { get; set; } = new("-{2,}");

    /// <summary>
    ///     Regex that matches consecutive underscores.
    /// </summary>
    public static Regex MultipleUnderscoresRegex { get; set; } = new("_{2,}");

    /// <summary>
    ///     Regex that matches trailing dashes.
    /// </summary>
    public static Regex TrailingDashesRegex { get; set; } = new("-+$");

    /// <summary>
    ///     Regex that matches words.
    /// </summary>
    public static Regex WordsRegex { get; set; } =
        new(@"([A-ZÆØÅ][a-zæøå]+|[a-zæøå]+|(?<![^\W_])[A-ZÆØÅ]+(?![^\W_])|\B[A-ZÆØÅ]{3,}|[A-ZÆØÅ])");

    /// <summary>
    ///     Regex that matches camelCase with digits and up to three consecutive capital letters.
    /// </summary>
    public static Regex CamelCaseWithDigitsRegex { get; set; } =
        new("^[a-z][a-z0-9]*(([A-Z]{1,3}[a-z0-9]+)*[A-Z]{0,3}|([a-z0-9]+[A-Z]{1,3})*|[A-Z]{1,3})$");

    /// <summary>
    ///     Regex that matches PascalCase with digits and up to three consecutive capital letters.
    /// </summary>
    public static Regex PascalCaseWithDigitsRegex { get; set; } = new(
        "^[A-Z](([A-Z]{1,2}[a-z0-9]+)+([A-Z]{1,3}[a-z0-9]+)*[A-Z]{0,3}|([a-z0-9]+[A-Z]{0,3})*|[A-Z]{1,2})$");

    /// <summary>
    ///     Regex that matches kebab-case without digits.
    /// </summary>
    public static Regex KebabCaseRegex { get; set; } = new("^[a-z-]+$");
}
