using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# class.
/// </summary>
public class CSharpClass : ClassBase
{
    /// <summary>
    ///     Creates a new class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpClass(string name, string @namespace, string? documentation) : base(name, @namespace)
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
            TemplateLoader = new CSharpTemplateLoader()
        };
        var scriptObject = new ScriptObject();
        scriptObject.Import(this);
        context.PushGlobal(scriptObject);
        var template = Scriban.Template.Parse(Template);
        return template.Render(context);
    }

    /// <summary>
    /// The template for a C# class.
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
        public class {{ name }}{{ if implementations | array.size > 0 ~}} : {{~ for implementation in implementations ~}}{{ implementation.name }}{{~ if !loop.last ~}}, {{~ end ~}}{{~ end ~}}{{~ end }}
        {
        {{~ for field in fields ~}}
            {{ include 'field' field }}
        {{~ end ~}}
        {{~ for constructor in constructors ~}}
            {{ include 'constructor' constructor }}
        {{~ end ~}}
        {{~ for implementation in implementations ~}}
            {{~ for property in implementation.properties ~}}
            {{ include 'property' property }}
            {{~ end ~}}
        {{~ end ~}}
        {{~ for property in properties ~}}
            {{ include 'property' property }}
        {{~ end ~}}
        {{~ for implementation in implementations ~}}
            {{~ for method in implementation.methods ~}}
            {{ include 'method' method }}
            {{~ end ~}}
        {{~ end ~}}
        {{~ for method in methods ~}}
            {{ include 'method' method }}
        {{~ end ~}}
        }
        """;
}
