using System.Text;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# class.
/// </summary>
public class CSharpClass : ClassBase
{
    /// <summary>
    /// Creates a new class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpClass(string name, string @namespace, string? documentation = default) : base(name, @namespace)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocumentationBlock = new CSharpDocumentationBlock(documentation);
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        {{Usings.Aggregate(string.Empty, (current, @using) => current + $"using {@using};{Environment.NewLine}")}}
        namespace {{Namespace}}

        {{DocumentationBlock?.Compile()}}
        public class {{Name.ToPascalCase()}} {
        {{AddMembers()}}
        }
        """;

    string AddMembers()
    {
        StringBuilder builder = new();
        for (int i = 0; i < Members.Count; i++)
        {
            if (i == 0)
            {
                _ = builder.AppendLine(Members[i].Compile().Indent());
                _ = builder.AppendLine();
            }
            else if (i < Members.Count - 1)
            {
                _ = builder.AppendLine(Members[i].Compile().Indent());
                _ = builder.AppendLine();
            }
            else
            {
                _ = builder.Append(Members[i].Compile().Indent());
            }
        }

        return builder.ToString();
    }
}
