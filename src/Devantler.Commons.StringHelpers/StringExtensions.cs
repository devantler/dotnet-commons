using System.Text;
using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static class StringExtensions
{
    public static string Indent(this string text, int spaces = 4)
    {
        StringBuilder builder = new();
        string[] lines = text.Split(Environment.NewLine.ToCharArray());
        for (int i = 0; i < text.Split(Environment.NewLine.ToCharArray()).Length; i++)
        {
            _ = i < lines.Length - 1
                ? builder.Append(new string(' ', spaces)).AppendLine(lines[i])
                : builder.Append(new string(' ', spaces)).Append(lines[i]);
        }

        return builder.ToString();
    }

    public static string ToPascalCase(this string text)
    {
        MatchCollection matches = RegexLibrary.WordsRegex.Matches(text);

        System.Globalization.TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
        StringBuilder builder = new();
        foreach (Match match in matches.Cast<Match>())
            _ = builder.Append(textInfo.ToTitleCase(match.Value.ToLower()));
        return builder.ToString();
    }

    public static string ToCamelCase(this string text)
    {
        string pascalCase = text.ToPascalCase();

        return pascalCase.Substring(0, 1).ToLower() + pascalCase.Substring(1);
    }

    public static string ToPlural(this string text) =>
        text.EndsWith("s", StringComparison.OrdinalIgnoreCase) ? text + "es" : text + "s";

    public static string ToKebabCase(this string text)
    {
        text = RegexLibrary.NonAlphanumericRegex.Replace(text, "-");

        text = RegexLibrary.SpaceRegex.Replace(text, "-");

        text = RegexLibrary.MultipleDashesRegex.Replace(text, "-");

        text = RegexLibrary.TrailingDashesRegex.Replace(text, string.Empty);

        text = text.StartsWith("-") ? text.Substring(1) : text;

        text = RegexLibrary.CamelCaseRegex.Replace(text, "$1-$2");

        text = RegexLibrary.PascalCaseRegex.Replace(text, "$1-$2");

        return text.ToLower();
    }
}
