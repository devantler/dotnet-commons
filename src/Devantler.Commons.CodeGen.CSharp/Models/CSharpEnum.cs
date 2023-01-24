using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# enum.
/// </summary>
public class CSharpEnum : EnumBase
{
    /// <summary>
    ///     Creates a new enumeration.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpEnum(string name, string @namespace, string? documentation) : base(name, @namespace) =>
        DocBlock = documentation != null
            ? new CSharpDocBlock(documentation)
            : null;

    /// <inheritdoc />
    public override IDocBlock? DocBlock { get; }

    /// <inheritdoc />
    public override string Compile()
    {
        var templateLoader = new CSharpTemplateLoader();
        var context = new TemplateContext
        {
            TemplateLoader = templateLoader
        };
        var script = new ScriptObject();
        script.Import(this);
        context.PushGlobal(script);
        var template = Scriban.Template.Parse(Template);
        return template.Render(context);
    }

    /// <summary>
    /// The template for a C# enum.
    /// </summary>
    public static string Template =>
        """
        {{- for using in imports ~}}
        {{ include 'using' using }}
        {{~ end ~}}
        {{~ if !(namespace | string.empty) ~}}
        namespace {{ namespace }};
        {{~ end ~}}
        {{~ if doc_block ~}}
        {{ include 'doc_block' doc_block }}
        {{- end ~}}
        public enum {{ name }}
        {
        {{~ for value in values ~}}
            {{ include 'enum_symbol' value }}{{ if !for.last }},{{ end }}
        {{~ end ~}}
        }
        """;
}
