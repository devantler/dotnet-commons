using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# compilation
/// </summary>
public class CSharpCompilation : CompilationBase
{
    /// <inheritdoc />
    public override Dictionary<string, string> Compile(CodeGenerationOptions? options = null)
    {
        {
            var result = new Dictionary<string, string>();

            foreach (var @interface in Interfaces)
            {
                @interface.Namespace = !string.IsNullOrEmpty(options?.NamespaceToUse)
                    ? options.NamespaceToUse
                    : @interface.Namespace;
                string code = @interface.Compile();
                result.Add($"{@interface.Name}.g.cs", code);
            }

            foreach (var @class in Classes)
            {
                @class.Namespace = !string.IsNullOrEmpty(options?.NamespaceToUse)
                    ? options.NamespaceToUse
                    : @class.Namespace;
                string code = @class.Compile();
                result.Add($"{@class.Name}.g.cs", code);
            }

            foreach (var @enum in Enums)
            {
                @enum.Namespace = !string.IsNullOrEmpty(options?.NamespaceToUse)
                    ? options.NamespaceToUse
                    : @enum.Namespace;
                string code = @enum.Compile();
                result.Add($"{@enum.Name}.g.cs", code);
            }

            return result;
        }
    }
}
