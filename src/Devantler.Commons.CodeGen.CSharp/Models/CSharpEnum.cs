using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# enum.
/// </summary>
public class CSharpEnum : EnumBase
{
    /// <summary>
    /// Creates a new enum.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpEnum(string name, string @namespace, string? documentation = default) : base(name, @namespace)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocumentationBlock = new CSharpDocumentationBlock(documentation);
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        namespace {{Namespace}}

        {{DocumentationBlock?.Compile()}}
        public enum {{Name.ToPascalCase()}}
        {
            {{string.Join($",{Environment.NewLine}", Values.Select(v => v))}}
        }
        """;
}
