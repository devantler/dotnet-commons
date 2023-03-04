using Devantler.Commons.CodeGen.Core;

/// <summary>
/// A parser that parses an object into a string.
/// </summary>
public interface IParser<T>
{
    /// <summary>
    /// Parses an object of type <typeparamref name="T"/> into a string.
    /// </summary>
    string Parse(T @object, Language language);
}
