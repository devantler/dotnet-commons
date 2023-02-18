namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a compilation.
/// </summary>
public interface ICompilation
{
    /// <summary>
    /// A list of compilable types in the compilation.
    /// </summary>
    public List<IType> Types { get; }

    /// <summary>
    /// Compiles the compilation.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public Dictionary<string, string> Compile(CodeGenerationOptions? options = null);
}
