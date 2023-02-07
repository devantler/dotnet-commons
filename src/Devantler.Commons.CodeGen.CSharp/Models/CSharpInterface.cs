using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# interface.
/// </summary>
public class CSharpInterface : InterfaceBase
{
    /// <summary>
    ///     Creates a new interface.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpInterface(string name, string? @namespace = default, string? documentation = default) : base(name, @namespace)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocBlock = new CSharpDocBlock(documentation);
    }

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
    /// The template for a C# interface.
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
        public interface {{ name }}
        {
        {{~ for property in properties ~}}
            {{ include 'property' property }}
        {{~ end ~}}
        {{~ for method in methods ~}}
            {{ include 'method' method }}
        {{~ end ~}}
        }
        """;
}
