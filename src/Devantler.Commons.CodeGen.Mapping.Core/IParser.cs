using Devantler.Commons.CodeGen.Core;

/// <summary>
/// A parser that parses an object into a string.
/// </summary>
public interface IParser<TType, TOptions>
{
    /// <summary>
    /// Parses an object of type <typeparamref name="TType"/> into a string.
    /// </summary>
    string Parse(TType @object, Language language, Action<TOptions>? action = default);
}
