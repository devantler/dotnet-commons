namespace Devantler.Commons.StringHelpers;

/// <summary>
/// Provides extension methods for <see cref="string" /> that help with grammar.
/// </summary>
public static class GrammarStringExtensions
{
    /// <summary>
    /// Converts a word to plural.
    /// </summary>
    /// <param name="word"></param>
    public static string ToPlural(this string word)
    {
        return word.EndsWith("es", StringComparison.OrdinalIgnoreCase)
            ? word
            : word.EndsWith("s", StringComparison.OrdinalIgnoreCase)
                ? word + "es"
                : word + "s";
    }
}
