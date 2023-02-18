using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;
using Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

/// <summary>
///     A mapper for mapping an Avro schema to a compilation.
/// </summary>
public class AvroModelsCompilationMapper : ICompilationMapper<Schema>
{
    /// <inheritdoc />
    public ICompilation Map(Schema rootSchema, Language language)
    {
        return language switch
        {
            Language.CSharp => MapToCSharp(rootSchema),
            _ => throw new NotSupportedException($"The language {language} is not supported.")
        };
    }

    CSharpCompilation MapToCSharp(Schema rootSchema)
    {
        var compilation = new CSharpCompilation();
        foreach (var schema in rootSchema.Flatten())
        {
            switch (schema)
            {
                case RecordSchema recordSchema:
                    CSharpClass @class = new(recordSchema.Name, recordSchema.Namespace, recordSchema.Documentation);

                    _ = @class.AddProperty(new CSharpProperty(Visibility.Public, "Guid", "Id", documentation: "The unique identifier of the entity."));
                    foreach (var field in recordSchema.Fields)
                    {
                        if (string.Equals(field.Name, "id", StringComparison.OrdinalIgnoreCase))
                            continue;

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
}
