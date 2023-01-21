using System.Linq;
using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# compilation
/// </summary>
public class CSharpCompilation : CompilationBase
{
    /// <inheritdoc />
    public override Dictionary<string, string> Compile()
    {
        {
            var result = new Dictionary<string, string>();

            foreach (var @interface in Interfaces)
            {
                string code = @interface.Compile();
                result.Add($"{@interface.Name}.g.cs", code);
            }

            foreach (var @class in Classes)
            {
                string code = @class.Compile();
                result.Add($"{@class.Name}.g.cs", code);
            }

            foreach (var @enum in Enums)
            {
                string code = @enum.Compile();
                result.Add($"{@enum.Name}.g.cs", code);
            }

            return result;
        }
    }
}
