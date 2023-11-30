using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# method.
/// </summary>
/// <remarks>
/// Creates a new C# method.
/// </remarks>
/// <param name="name"></param>
public class CSharpMethod(string name) : IFluentMethod<CSharpMethod>
{
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string ReturnType { get; set; } = "void";
    /// <inheritdoc/>
    public List<string> Statements { get; set; } = [];
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IParameter> Parameters { get; } = [];
    /// <summary>
    /// The attributes on the method.
    /// </summary>
    public List<string> Attributes { get; } = [];
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
    /// <summary>
    /// Whether the method is an expression-bodied method or not.
    /// </summary>
    public bool IsExpressionBodied { get; set; }
    /// <inheritdoc/>
    public bool IsAsynchronous { get; set; }
    /// <summary>
    /// Sets whether the method is a an expression-bodied method or not.
    /// </summary>
    /// <param name="isExpressionBodied"></param>
    public CSharpMethod SetIsExpressionBodied(bool isExpressionBodied)
    {
        IsExpressionBodied = isExpressionBodied;
        return this;
    }
    /// <inheritdoc/>
    public CSharpMethod AddParameter(IParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
    /// <summary>
    /// Adds an attribute to the method.
    /// </summary>
    /// <param name="attribute"></param>
    /// <returns></returns>
    public CSharpMethod AddAttribute(string attribute)
    {
        Attributes.Add(attribute);
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

    /// <inheritdoc/>
    public CSharpMethod SetIsAsynchronous(bool isAsynchronous)
    {
        IsAsynchronous = isAsynchronous;
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
        {{~ for attribute in $1.attributes ~}}
        [{{ attribute }}]
        {{~ end ~}}
        {{ $1.visibility != "Private" ? ($1.visibility | string.downcase) + " " : ""}}{{ if $1.is_static }}static {{ else }}{{ $1.is_override == true ? "override " : "" }}{{ end }}{{ $1.is_partial ? "partial " : "" }}{{ $1.is_asynchronous ? "async " : "" }}{{ $1.return_type + " " }}{{ $1.name }}({{ for parameter in $1.parameters }}{{ if for.first && $1.is_extension_method }}this {{ end }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
        {{~ if $1.is_expression_bodied && ($1.statements | array.size == 1) ~}}
            => {{ $1.statements[0] }}
        {{~ else ~}}
        {
            {{~ for statement in $1.statements ~}}
            {{ statement }}
            {{~ end ~}}
        }
        {{- end ~}}
        """;
}
