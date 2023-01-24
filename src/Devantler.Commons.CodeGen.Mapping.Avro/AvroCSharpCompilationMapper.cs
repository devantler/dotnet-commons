using Avro;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;
using Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A mapper for mapping an Avro schema to a C# compilation.
/// </summary>
public static class AvroCSharpCompilationMapper
{
    /// <summary>
    /// Maps an Avro schema to a C# compilation containing C# models.
    /// </summary>
    /// <param name="rootSchema"></param>
    public static CSharpCompilation MapToCSharpModels(Schema rootSchema)
    {
        var compilation = new CSharpCompilation();
        foreach (var schema in rootSchema.Flatten())
        {
            switch (schema)
            {
                case RecordSchema recordSchema:
                    CSharpClass @class = new(recordSchema.Name, recordSchema.Namespace, recordSchema.Documentation);

                    if (!recordSchema.Fields.Any(x => x.Name == "Id"))
                    {
                        var idProperty = new CSharpProperty(Visibility.Public, "string", "Id", null, "The unique identifier of the entity.");
                        _ = @class.AddProperty(idProperty);
                    }
                    foreach (var field in recordSchema.Fields)
                    {
                        _ = @class.AddProperty(field);
                    }
                    _ = compilation.AddClass(@class);
                    break;
                case EnumSchema enumSchema:
                    CSharpEnum @enum = new(enumSchema.Name, enumSchema.Namespace, enumSchema.Documentation);

                    for (int i = 0; i < enumSchema.Symbols.Count; i++)
                        _ = @enum.AddValue(new CSharpEnumSymbol(enumSchema.Symbols[i], i.ToString()));

                    _ = compilation.AddEnum(@enum);
                    break;
                default:
                    continue;
            }
        }
        return compilation;
    }

    /// <summary>
    /// Maps an Avro schema to a C# compilation containing C# entities.
    /// </summary>
    /// <param name="rootSchema"></param>
    public static CSharpCompilation MapToCSharpEntities(Schema rootSchema)
    {
        var compilation = new CSharpCompilation();
        foreach (var schema in rootSchema.Flatten())
        {
            if (schema is not RecordSchema recordSchema)
                continue;

            CSharpClass @class = new(recordSchema.Name, recordSchema.Namespace, recordSchema.Documentation);

            CSharpInterface @interface = new("IEntity", recordSchema.Namespace);
            _ = @interface.AddProperty(new CSharpProperty(Visibility.Public, "Guid", "Id", "null!", "The unique identifier of the entity."));
            _ = @class.AddImplementation(@interface);

            foreach (var field in recordSchema.Fields)
            {
                _ = @class.AddProperty(field);
            }
            _ = compilation.AddClass(@class);
        }
        return compilation;
    }
}
