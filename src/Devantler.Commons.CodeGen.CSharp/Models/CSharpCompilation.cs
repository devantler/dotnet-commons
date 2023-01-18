using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# compilation
/// </summary>
public class CSharpCompilation : CompilationBase
{
    /// <inheritdoc />
    public override Dictionary<string, string> Compile(string? assemblyPath = default)
    {
        {
            var result = new Dictionary<string, string>();

            foreach (var @interface in Interfaces)
            {
                string code = @interface.Compile(assemblyPath);
                result.Add($"{@interface.Name}.cs", code);
            }

            foreach (var @class in Classes)
            {
                string code = @class.Compile(assemblyPath);
                result.Add($"{@class.Name}.cs", code);
            }

            foreach (var @enum in Enums)
            {
                string code = @enum.Compile(assemblyPath);
                result.Add($"{@enum.Name}.cs", code);
            }

            return result;
        }
    }
}
