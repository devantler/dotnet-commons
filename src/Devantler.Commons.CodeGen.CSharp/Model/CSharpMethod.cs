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
    /// <param name="type"></param>
    /// <param name="name"></param>
    public CSharpMethod(string type, string name)
    {
        ReturnType = type;
        Name = name;
    }
    /// <inheritdoc/>
    public Visibility Visibility => Visibility.Public;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string ReturnType { get; set; }
    /// <inheritdoc/>
    public List<string> Statements { get; set; } = new();
    /// <inheritdoc/>
    public IDocBlock? DocBlock { get; set; }
    /// <inheritdoc/>
    public List<IParameter> Parameters { get; } = new();
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
    public CSharpMethod SetDocBlock(IDocBlock docBlock)
    {
        if (docBlock is not null)
            DocBlock = docBlock;
        return this;
    }

    /// <summary>
    /// The template for a C# method.
    /// </summary>
    public static string Template =>
        """
        {{ if $1.doc_block }}{{ include 'doc_block' $1.doc_block }}{{ end ~}}
        {{ $1.visibility | string.downcase }} {{ $1.return_type }} {{ $1.name }}({{ for parameter in $1.parameters }}{{ include 'parameter' parameter }}{{ if !for.last }}, {{ end }}{{ end }})
        {
            {{ for statement in $1.statements ~}}
            {{~ statement ~}}
            {{~ end }}
        }
        """;
}
