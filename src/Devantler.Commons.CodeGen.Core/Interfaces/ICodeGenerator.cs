namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a code generator.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICodeGenerator<T> where T : ICompilation
{
    /// <summary>
    /// Generates code from the given code base.
    /// </summary>
    /// <param name="compilation"></param>
    /// <returns>Dictionary&lt;fileName, code&gt;</returns>
    public Dictionary<string, string> Generate(T compilation);
}
