using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp;

/// <summary>
///     A code generator for C#.
/// </summary>
public class CSharpCodeGenerator : ICodeGenerator<CSharpCompilation>
{
    /// <inheritdoc />
    public Dictionary<string, string> Generate(CSharpCompilation compilation, string? assemblyPath = default) => compilation.Compile(assemblyPath);
}
