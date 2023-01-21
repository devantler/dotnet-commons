using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# class.
/// </summary>
public class CSharpClass : ClassBase
{
    /// <summary>
    ///     Creates a new class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    /// <param name="documentation"></param>
    public CSharpClass(string name, string @namespace, string? documentation) : base(name, @namespace)
    {
        if (!string.IsNullOrWhiteSpace(documentation))
            DocBlock = new CSharpDocBlock(documentation);
    }

    /// <inheritdoc />
    public override IDocBlock? DocBlock { get; }

    /// <inheritdoc />
    public override string Compile()
    {
        var templateLoader = new TemplateLoader();
        var context = new TemplateContext
        {
            TemplateLoader = new TemplateLoader()
        };
        var scriptObject = new ScriptObject();
        scriptObject.Import(this);
        context.PushGlobal(scriptObject);
        string filePath = templateLoader.GetPath(context, new SourceSpan(), "class.sbn-cs");
        var template = Template.Parse(File.ReadAllText(filePath), filePath);
        return template.Render(context);
    }
}
