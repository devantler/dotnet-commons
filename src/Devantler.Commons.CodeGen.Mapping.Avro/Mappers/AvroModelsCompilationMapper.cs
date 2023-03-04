using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.Mapping.Core;
using Devantler.Commons.StringHelpers;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

/// <summary>
///     A mapper for mapping an Avro schema to a compilation.
/// </summary>
public class AvroModelsCompilationMapper : ICompilationMapper<Schema>
{

    private readonly AvroSchemaParser _parser = new();

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
                    var @class = new CSharpClass(recordSchema.Name)
                        .SetNamespace(recordSchema.Namespace)
                        .AddProperty(
                            new CSharpProperty("Guid", "Id")
                                .SetDocBlock(new CSharpDocBlock("The unique identifier for the record."))
                        );

                    if (recordSchema.Documentation != null)
                        _ = @class.SetDocBlock(new CSharpDocBlock(recordSchema.Documentation));

                    foreach (var field in recordSchema.Fields)
                    {
                        if (string.Equals(field.Name, "id", StringComparison.OrdinalIgnoreCase))
                            continue;

                        var property = new CSharpProperty(
                            _parser.Parse(field.Type, Language.CSharp), field.Name.ToPascalCase()
                        );

                        if (field.Documentation != null)
                            _ = property.SetDocBlock(new CSharpDocBlock(field.Documentation));

                        _ = @class.AddProperty(property);
                    }

                    _ = compilation.AddType(@class);
                    break;
                case EnumSchema enumSchema:
                    var @enum = new CSharpEnum(enumSchema.Name)
                        .SetNamespace(enumSchema.Namespace);

                    if (enumSchema.Documentation != null)
                        _ = @enum.SetDocBlock(new CSharpDocBlock(enumSchema.Documentation));

                    var symbols = enumSchema.Symbols.ToList();
                    for (int i = 0; i < symbols.Count; i++)
                        _ = @enum.AddValue(new CSharpEnumSymbol(symbols[i]).SetValue(i));

                    _ = compilation.AddType(@enum);
                    break;
                default:
                    continue;
            }
        }
        return compilation;
    }
}
