using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# enum.
/// </summary>
public class CSharpEnum : EnumBase
{
    /// <summary>
    ///     Creates a new enumeration.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpEnum(string name, string @namespace, string? documentation) : base(name, @namespace) =>
        DocBlock = documentation != null
            ? new CSharpDocBlock(documentation)
            : null;

    /// <inheritdoc />
    public override IDocBlock? DocBlock { get; }

    /// <inheritdoc />
    public override string Compile(string? assemblyPath = default)
    {
        var context = new TemplateContext
        {
            TemplateLoader = new TemplateLoader()
        };
        var script = new ScriptObject();
        script.Import(this);
        context.PushGlobal(script);
        const string enumerationTemplatePath = "templates/enum.sbn-cs";
        string filePath = !string.IsNullOrEmpty(assemblyPath) ?
            $"{assemblyPath}/{enumerationTemplatePath}" :
            enumerationTemplatePath;
        var template = Template.Parse(File.ReadAllText(filePath), filePath);
        return template.Render(context);
    }
}
