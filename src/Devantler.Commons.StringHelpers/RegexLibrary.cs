using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static class RegexLibrary
{
    public static Regex WordsRegex { get; set; } = new Regex("[A-Z][a-z]+|[a-z]+|[A-Z]");
}
