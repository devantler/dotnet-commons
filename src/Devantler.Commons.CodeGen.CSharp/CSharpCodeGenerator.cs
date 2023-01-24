using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.CSharp;

/// <summary>
///     A code generator for C#.
/// </summary>
public class CSharpCodeGenerator : ICodeGenerator
{
    /// <inheritdoc />
    public Dictionary<string, string> Generate(ICompilation compilation) => compilation.Compile();
}
