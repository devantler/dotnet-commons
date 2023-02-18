using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.Core;

/// <summary>
///     An interface representing a code generator.
/// </summary>
public interface ICodeGenerator
{
    /// <summary>
    ///     Generates code from the given code base.
    /// </summary>
    /// <param name="compilation"></param>
    /// <param name="options"></param>
    /// <returns>Dictionary&lt;fileName, code&gt;</returns>
    public Dictionary<string, string> Generate(ICompilation compilation, Action<CodeGenerationOptions>? options = null);
}
