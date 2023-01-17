using System.Text;

namespace Devantler.Commons.StringHelpers;

/// <summary>
///     Provides extension methods for <see cref="string" />.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    ///     Indents a string by the specified number of spaces. Or four spaces if no argument is provided.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="spaces"></param>
    /// <param name="ignoreFirstLine"></param>
    public static string Indent(this string text, int spaces = 4, bool ignoreFirstLine = false)
    {
        StringBuilder builder = new();
        string[] lines = text.Split(Environment.NewLine.ToCharArray());
        for (int i = 0; i < text.Split(Environment.NewLine.ToCharArray()).Length; i++)
        {
            if (i == 0 && ignoreFirstLine)
            {
                _ = builder.AppendLine(lines[i]);
                continue;
            }

            _ = i < lines.Length - 1
                ? builder.Append(new string(' ', spaces)).AppendLine(lines[i])
                : builder.Append(new string(' ', spaces)).Append(lines[i]);
        }

        return builder.ToString();
    }

    /// <summary>
    ///     Converts a string to PascalCase.
    /// </summary>
    /// <param name="text"></param>
    public static string ToPascalCase(this string text)
    {
        if (RegexLibrary.PascalCaseWithDigitsRegex.IsMatch(text))
            return text;
        if (RegexLibrary.CamelCaseWithDigitsRegex.IsMatch(text))
            return text[..1].ToUpper() + text[1..];

        text = RegexLibrary.WordsRegex
            .Replace(text, m => m.Value[..1].ToUpper() + m.Value[1..].ToLower());

        text = RegexLibrary.NonAlphanumericRegex.Replace(text, string.Empty);

        text = RegexLibrary.WhitespaceRegex.Replace(text, string.Empty);

        return text;
    }

    /// <summary>
    ///     Converts a string to camelCase.
    /// </summary>
    /// <param name="text"></param>
    public static string ToCamelCase(this string text)
    {
        if (RegexLibrary.CamelCaseWithDigitsRegex.IsMatch(text))
            return text;

        text = text.ToPascalCase();

        return text[..1].ToLower() + text[1..];
    }

    /// <summary>
    ///     Converts a string to kebab-case.
    /// </summary>
    /// <param name="text"></param>
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

    /// <summary>
    ///     Converts a word to plural.
    /// </summary>
    /// <param name="word"></param>
    public static string ToPlural(this string word) =>
        word.EndsWith("s", StringComparison.OrdinalIgnoreCase) ? word + "es" : word + "s";
}
