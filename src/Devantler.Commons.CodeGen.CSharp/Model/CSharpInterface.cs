using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# interface.
/// </summary>
public class CSharpInterface : IFluentInterface<CSharpInterface>
{
    /// <summary>
    /// Creates a new C# interface.
    /// </summary>
    /// <param name="name"></param>
    public CSharpInterface(string name) => Name = name;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Namespace { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IProperty> Properties { get; } = new();
    /// <inheritdoc/>
    public List<IMethod> Methods { get; } = new();
    /// <inheritdoc/>
    public List<IImport> Imports { get; } = new();
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
