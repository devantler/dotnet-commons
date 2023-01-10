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
        if (RegexLibrary.PascalCaseRegex.IsMatch(text))
            return text;
        else if (RegexLibrary.CamelCaseRegex.IsMatch(text))
            return text[..1].ToUpper() + text[1..];

        text = RegexLibrary.WordsRegex
            .Replace(text, m => m.Value[..1].ToUpper() + m.Value[1..].ToLower());

        text = RegexLibrary.NonAlphanumericRegex.Replace(text, string.Empty);

        text = RegexLibrary.WhitespaceRegex.Replace(text, string.Empty);

        return text;
    }

    public static string ToCamelCase(this string text)
    {
        if (RegexLibrary.CamelCaseRegex.IsMatch(text))
            return text;

        text = text.ToPascalCase();

        return text[..1].ToLower() + text[1..];
    }

    public static string ToKebabCase(this string text)
    {
        if (RegexLibrary.KebabCaseRegex.IsMatch(text))
            return text;

        text = text.ToPascalCase();

        return RegexLibrary.WordsRegex.Matches(text)
            .Select(m => m.Value)
            .Aggregate(new StringBuilder(), (sb, s) => sb.Append(s.ToLower()).Append('-'))
            .ToString()[..^1];
    }

    public static string ToPlural(this string text) =>
        text.EndsWith("s", StringComparison.OrdinalIgnoreCase) ? text + "es" : text + "s";
}
