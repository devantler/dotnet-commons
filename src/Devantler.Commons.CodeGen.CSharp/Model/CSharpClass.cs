using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
/// A model representing a C# class.
/// </summary>
public class CSharpClass : IFluentClass<CSharpClass>
{
    /// <summary>
    /// Creates a new C# class.
    /// </summary>
    /// <param name="name"></param>
    public CSharpClass(string name) => Name = name;
    /// <inheritdoc/>
    public List<IInterface> Implementations { get; } = new();
    /// <inheritdoc/>
    public List<IField> Fields { get; } = new();
    /// <inheritdoc/>
    public List<IProperty> Properties { get; } = new();
    /// <inheritdoc/>
    public List<IConstructor> Constructors { get; } = new();
    /// <inheritdoc/>
    public List<IMethod> Methods { get; } = new();
    /// <inheritdoc/>
    public List<IImport> Imports { get; } = new();
    /// <inheritdoc/>
    public IClass? BaseClass { get; set; }
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Namespace { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;

    /// <summary>
    /// Whether the class is a partial class or not.
    /// </summary>
    public bool IsPartial { get; set; }

    /// <inheritdoc/>
    public bool IsAbstract { get; set; }

    /// <inheritdoc/>
    public bool IsStatic { get; set; }

    /// <summary>
    /// Sets whether the class is a partial class or not.
    /// </summary>
    /// <param name="isPartial"></param>
    public CSharpClass SetIsPartial(bool isPartial)
    {
        IsPartial = isPartial;
        return this;
    }

    /// <inheritdoc/>
    public CSharpClass SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }

    /// <inheritdoc/>
    public CSharpClass SetIsAbstract(bool isAbstract)
    {
        IsAbstract = isAbstract;
        return this;
    }

    /// <inheritdoc/>
    public CSharpClass SetIsStatic(bool isStatic)
    {
        IsStatic = isStatic;
        return this;
    }

    /// <inheritdoc/>
    public CSharpClass SetBaseClass(CSharpClass? @class)
    {
        BaseClass = @class;
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddImplementation(IInterface implementation)
    {
        Implementations.Add(implementation);
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddField(IField field)
    {
        Fields.Add(field);
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddProperty(IProperty property)
    {
        Properties.Add(property);
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddConstructor(IConstructor constructor)
    {
        Constructors.Add(constructor);
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddMethod(IMethod method)
    {
        Methods.Add(method);
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass SetDocBlock(IDocBlock docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <inheritdoc/>
    public CSharpClass AddImport(IImport import)
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
        {{~ if !(base_class?.namespace | string.empty)  ~}}
        using {{ base_class.namespace }};
        {{~ end ~}}
        {{- for using in imports ~}}
        {{ include 'using' using }}
        {{~ end ~}}
        {{~ if !(namespace | string.empty) ~}}
        namespace {{ namespace }};
        {{~ end ~}}
        {{~ if doc_block ~}}
        {{ include 'doc_block' doc_block }}
        {{- end ~}}
        {{ visibility != "Private" ? (visibility | string.downcase) + " " : "" }}{{ is_static ? "static " : "" }}{{ is_abstract ? "abstract " : "" }}{{ is_partial ? "partial " : "" }}class {{ name }}{{ if base_class || (implementations | array.size > 0) }} : {{ end }}{{ base_class ? base_class.name : "" }}{{ if implementations | array.size > 0 }}{{ base_class ? ", " : "" }}{{ for implementation in implementations }}{{ implementation.name }}{{ if !for.last }}, {{ end }}{{~ end ~}}{{~ end }}
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
