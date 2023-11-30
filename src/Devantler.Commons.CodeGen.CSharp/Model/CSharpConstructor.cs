using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# constructor.
/// </summary>
/// <remarks>
/// Creates a new C# constructor.
/// </remarks>
/// <param name="name"></param>
public class CSharpConstructor(string name) : IFluentConstructor<CSharpConstructor>
{
    /// <inheritdoc/>
    public Visibility Visibility { get; set; } = Visibility.Public;
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<string> Statements { get; set; } = [];
    /// <inheritdoc/>
    public List<IConstructorParameter> Parameters { get; } = [];
    /// <inheritdoc/>
    public CSharpConstructor AddParameter(IConstructorParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructor AddStatement(string statement)
    {
        Statements.Add(statement);
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructor SetDocBlock(IDocBlock docBlock)
    {
        if (docBlock is not null)
            DocBlock = docBlock;
        return this;
    }

    /// <inheritdoc/>
    public CSharpConstructor SetVisibility(Visibility visibility)
    {
        Visibility = visibility;
        return this;
    }

    /// <summary>
    /// The template for a C# constructor.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{- $1.visibility | string.downcase }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'constructor_parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }}){{ if $1.parameters | array.map 'is_base_parameter' | array.contains true }} : base({{ for parameter in $1.parameters }}{{ if parameter.is_base_parameter }}{{ parameter.base_parameter_name }}{{ if !for.last }}, {{ end }}{{ end }}{{ end }}){{ end }}
        {
            {{~ for statement in $1.statements ~}}
            {{ statement }}
            {{~ end ~}}
        }
        """;
}
