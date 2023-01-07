using System.Text;
using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static class StringExtensions
{
    public static string IndentBy(this string text, int spaces = 4)
    {
        var builder = new StringBuilder();
        var lines = text.Split(Environment.NewLine.ToCharArray());
        for (int i = 0; i < text.Split(Environment.NewLine.ToCharArray()).Length; i++)
        {
            if (i < lines.Length - 1)
                builder.Append(new string(' ', spaces)).AppendLine(lines[i]);
            else
                builder.Append(new string(' ', spaces)).Append(lines[i]);
        }

        return builder.ToString();
    }

    public static string ToPascalCase(this string text)
    {
        var matches = RegexLibrary.WordsRegex.Matches(text);

        var textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
        var builder = new StringBuilder();
        foreach (var match in matches.Cast<Match>())
            builder.Append(textInfo.ToTitleCase(match.Value.ToLower()));
        return builder.ToString();
    }

    public static string ToCamelCase(this string text)
    {
        var pascalCase = text.ToPascalCase();

        return pascalCase.Substring(0, 1).ToLower() + pascalCase.Substring(1);
    }

    public static string ToPlural(this string text)
    {
        if (text.EndsWith("s", StringComparison.OrdinalIgnoreCase))
            return text + "es";
        return text + "s";
    }
}
