using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# enum.
/// </summary>
public class CSharpEnum : EnumBase
{
    /// <inheritdoc/>
    public override IDocBlock? DocBlock { get; }

    /// <summary>
    /// Creates a new enumeration.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpEnum(string name, string @namespace, string? documentation) : base(name, @namespace)
    {
        DocBlock = documentation != null
            ? new CSharpDocBlock(documentation)
            : null;
    }

    /// <inheritdoc/>
    public override string Compile()
    {
        var context = new TemplateContext
        {
            TemplateLoader = new TemplateLoader(),
        };
        var script = new ScriptObject();
        script.Import(this);
        context.PushGlobal(script);
        const string filePath = "templates/enum.sbn-cs";
        var template = Template.Parse(File.ReadAllText(filePath), filePath);
        return template.Render(context);
    }
}
