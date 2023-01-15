using System.Text;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# interface.
/// </summary>
public class CSharpInterface : InterfaceBase
{
    /// <summary>
    /// Creates a new interface.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpInterface(string name, string @namespace, string? documentation = default) : base(name, @namespace)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocumentationBlock = new CSharpDocumentationBlock(documentation);
    }

    /// <inheritdoc/>
    public override string Compile() =>
        $$"""
        namespace {{Namespace}}

        {{DocumentationBlock?.Compile()}}
        public interface {{Name.ToPascalCase()}}
        {
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
