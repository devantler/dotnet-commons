namespace Devantler.Commons.CodeGen.Core;

/// <summary>
/// Options for code generation.
/// </summary>
public class CodeGenerationOptions
{
    /// <summary>
    /// Override the namespace used for code in the compilation.
    /// </summary>
    public string NamespaceToUse { get; set; } = string.Empty;
}
