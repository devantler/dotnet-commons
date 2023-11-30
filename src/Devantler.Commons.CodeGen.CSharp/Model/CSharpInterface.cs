using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# interface.
/// </summary>
/// <remarks>
/// Creates a new C# interface.
/// </remarks>
/// <param name="name"></param>
public class CSharpInterface(string name) : IFluentInterface<CSharpInterface>
{
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string? Namespace { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IProperty> Properties { get; } = [];
    /// <inheritdoc/>
    public List<IMethod> Methods { get; } = [];
    /// <inheritdoc/>
    public List<IImport> Imports { get; } = [];
    /// <inheritdoc/>
    public List<IInterface> Implementations { get; } = [];
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public bool IsPartial { get; set; }
    /// <inheritdoc/>
    public CSharpInterface AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface AddMethod(IMethod method)
    {
        Methods.Add(method);
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface AddProperty(IProperty property)
    {
        Properties.Add(property);
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface AddImplementation(IInterface implementation)
    {
        Implementations.Add(implementation);
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <inheritdoc/>
    public CSharpInterface SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
    /// <summary>
    /// Sets whether the interface is partial or not.
    /// </summary>
    /// <param name="isPartial"></param>
    public object SetIsPartial(bool isPartial)
    {
        IsPartial = isPartial;
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
        {{ visibility != "Private" ? (visibility | string.downcase) + " " : ""}}{{ is_partial ? "partial " : "" }}interface {{ name }}{{ if implementations | array.size > 0 }} : {{ for implementation in implementations }}{{ implementation.name }}{{ if !for.last }}, {{ end }}{{~ end ~}}{{~ end }}
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
