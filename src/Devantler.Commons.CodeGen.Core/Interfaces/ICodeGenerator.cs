namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a code generator.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICodeGenerator<T> where T : ICodeCollection
{
    /// <summary>
    /// Generates code from the given code base.
    /// </summary>
    /// <param name="codeBase"></param>
    public Dictionary<string, string> Generate(T codeBase);
}
