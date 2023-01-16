using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# compilation
/// </summary>
public class CSharpCompilation : CompilationBase
{
    /// <inheritdoc/>
    public override Dictionary<string, string> Compile()
    {
        {
            var result = new Dictionary<string, string>();

            foreach (IInterface @interface in Interfaces)
            {
                string code = @interface.Compile();
                result.Add($"{@interface.Name}.cs", code);
            }

            foreach (IClass @class in Classes)
            {
                string code = @class.Compile();
                result.Add($"{@class.Name}.cs", code);
            }

            foreach (IEnum @enum in Enums)
            {
                string code = @enum.Compile();
                result.Add($"{@enum.Name}.cs", code);
            }

            return result;
        }
    }
}
