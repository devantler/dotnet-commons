using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.CSharp.Models;
using Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

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

                    foreach (var field in recordSchema.Fields)
                    {
                        _ = @class.AddProperty(field);
                    }

                    _ = compilation.AddClass(@class);
                    break;
                case EnumSchema enumSchema:
                    CSharpEnum @enum = new(enumSchema.Name, enumSchema.Namespace, enumSchema.Documentation);

                    var symbols = enumSchema.Symbols.ToList();
                    for (int i = 0; i < symbols.Count; i++)
                        _ = @enum.AddValue(new CSharpEnumSymbol(symbols[i], i.ToString()));

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

            CSharpClass @class = new($"{recordSchema.Name}Entity", recordSchema.Namespace, recordSchema.Documentation);

            foreach (var field in recordSchema.Fields)
            {
                _ = @class.AddProperty(field);
            }
            _ = compilation.AddClass(@class);
        }
        return compilation;
    }
}
