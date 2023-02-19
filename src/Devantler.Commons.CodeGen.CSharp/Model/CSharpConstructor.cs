using Devantler.Commons.CodeGen.Core.FluentModel;
using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# constructor.
/// </summary>
public class CSharpConstructor : IFluentConstructor<CSharpConstructor>
{
    /// <summary>
    /// Creates a new C# constructor.
    /// </summary>
    /// <param name="name"></param>
    public CSharpConstructor(string name) => Name = name;
    /// <inheritdoc/>
    public Visibility Visibility => Visibility.Public;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Body { get; set; }
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IConstructorParameter> Parameters { get; } = new();
    /// <inheritdoc/>
    public CSharpConstructor AddParameter(IConstructorParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructor SetBody(string body)
    {
        Body = body;
        return this;
    }
    /// <inheritdoc/>
    public CSharpConstructor SetDocBlock(IDocBlock docBlock)
    {
        if (docBlock is not null)
            DocBlock = docBlock;
        return this;
    }
    /// <summary>
    /// The template for a C# constructor.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{- $1.visibility | string.downcase }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }}){{ if $1.parameters | array.map 'is_base_parameter' | array.contains true }} : base({{ for parameter in $1.parameters }}{{ if parameter.is_base_parameter }}{{ parameter.name }}{{ if !for.last }}, {{ end }}{{ end }}{{ end }}){{ end }}
        {
            {{ $1.body }}
        }
        """;
}
