using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# method.
/// </summary>
public class CSharpMethod : IFluentMethod<CSharpMethod>
{
    /// <summary>
    /// Creates a new C# method.
    /// </summary>
    /// <param name="name"></param>
    public CSharpMethod(string name) => Name = name;
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string ReturnType { get; set; } = "void";
    /// <inheritdoc/>
    public List<string> Statements { get; set; } = new();
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IParameter> Parameters { get; } = new();
    /// <inheritdoc/>
    public bool IsOverride { get; set; }
    /// <inheritdoc/>
    public bool IsStatic { get; set; }
    /// <summary>
    /// Whether the method is a partial method or not.
    /// </summary>
    public bool IsPartial { get; set; }
    /// <summary>
    /// Whether the method is an extension method or not.
    /// </summary>
    public bool IsExtensionMethod { get; set; }
    /// <inheritdoc/>
    public CSharpMethod AddParameter(IParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
    /// <inheritdoc/>
    public CSharpMethod AddStatement(string statement)
    {
        Statements.Add(statement);
        return this;
    }

    /// <inheritdoc/>
    public CSharpMethod SetReturnType(string returnType)
    {
        ReturnType = returnType;
        return this;
    }

    /// <inheritdoc/>
    public CSharpMethod SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }

    /// <inheritdoc/>
    public CSharpMethod SetIsStatic(bool isStatic)
    {
        IsStatic = isStatic;
        return this;
    }

    /// <summary>
    /// Sets the partial modifier.
    /// </summary>
    /// <param name="isPartial"></param>
    public CSharpMethod SetIsPartial(bool isPartial)
    {
        IsPartial = isPartial;
        return this;
    }

    /// <inheritdoc/>
    public CSharpMethod SetDocBlock(IDocBlock docBlock)
    {
        if (docBlock is not null)
            DocBlock = docBlock;
        return this;
    }

    /// <inheritdoc/>
    public CSharpMethod SetIsOverride(bool isOverride)
    {
        IsOverride = isOverride;
        return this;
    }

    /// <summary>
    /// Sets if the method is an extension method or not.
    /// </summary>
    /// <param name="isExtension"></param>
    public CSharpMethod SetIsExtensionMethod(bool isExtension)
    {
        IsStatic = true;
        IsExtensionMethod = isExtension;
        return this;
    }

    /// <summary>
    /// The template for a C# method.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block
        include 'doc_block' $1.doc_block
        end ~}}
        {{ $1.visibility != "Private" ? ($1.visibility | string.downcase) + " " : ""}}{{ if $1.is_static }}static {{ else }}{{ $1.is_override == true ? "override " : "" }}{{ end }}{{ $1.is_partial == true ? "partial " : "" }}{{ $1.return_type + " " }}{{ $1.name }}({{ for parameter in $1.parameters }}{{ if for.first && $1.is_extension_method }}this {{ end }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
        {
            {{~ for statement in $1.statements ~}}
            {{ statement }}
            {{~ end ~}}
        }
        """;
}
