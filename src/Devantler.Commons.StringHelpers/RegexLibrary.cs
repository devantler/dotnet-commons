using System.Text.RegularExpressions;

namespace Devantler.Commons.StringHelpers;

public static partial class RegexLibrary
{
    [GeneratedRegex("[A-Z][a-z]+|[a-z]+|[A-Z]")]
    public static partial Regex WordsRegex();
}
