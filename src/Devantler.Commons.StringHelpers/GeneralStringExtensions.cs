namespace Devantler.Commons.StringHelpers;

/// <summary>
/// General purpose string extensions.
/// </summary>
public static class GeneralStringExtensions
{
    /// <summary>
    /// Returns null if the string is null or empty.
    /// </summary>
    public static string? NullIfEmpty(this string text)
        => string.IsNullOrEmpty(text) ? null : text;
}