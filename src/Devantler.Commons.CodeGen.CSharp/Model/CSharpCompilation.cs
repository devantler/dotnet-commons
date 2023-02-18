using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# compilation
/// </summary>
public class CSharpCompilation : IFluentCompilation<CSharpCompilation>
{
    /// <inheritdoc/>
    public List<IType> Types { get; } = new();

    /// <inheritdoc/>
    public CSharpCompilation AddType(IType type)
    {
        Types.Add(type);
        return this;
    }

    /// <inheritdoc />
    public Dictionary<string, string> Compile(CodeGenerationOptions? options = null)
    {
        {
            var result = new Dictionary<string, string>();

            foreach (var type in Types)
            {
                type.Namespace = !string.IsNullOrEmpty(options?.NamespaceToUse)
                    ? options.NamespaceToUse
                    : type.Namespace;
                string code = type.Compile();
                result.Add($"{type.Name}.g.cs", code);
            }

            return result;
        }
    }
}
