using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# enum.
/// </summary>
/// <remarks>
/// Creates a new C# enum.
/// </remarks>
/// <param name="name"></param>
public class CSharpEnum(string name) : IFluentEnum<CSharpEnum>
{
    /// <inheritdoc/>
    public List<IEnumValue> Values { get; } = [];
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string? Namespace { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IImport> Imports { get; } = [];
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public CSharpEnum AddValue(IEnumValue value)
    {
        Values.Add(value);
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnum SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnum SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnum SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <inheritdoc/>
    public CSharpEnum AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }
    /// <inheritdoc />
    public string Compile()
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
        {{ visibility != "Private" ? (visibility | string.downcase) + " " : ""}}enum {{ name }}
        {
        {{~ for value in values ~}}
            {{ include 'enum_symbol' value }}{{ if !for.last }},{{ end }}
        {{~ end ~}}
        }
        """;
}
