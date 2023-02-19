using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Mapping.Core;
using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

/// <summary>
/// A mapper for mapping an Avro schema to a compilation containing entities.
/// </summary>
public class AvroEntitiesCompilationMapper : ICompilationMapper<Schema>
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
            if (schema is not RecordSchema recordSchema)
                continue;

            var @class = new CSharpClass($"{recordSchema.Name}Entity")
                .SetNamespace(recordSchema.Namespace)
                .AddProperty(
                    new CSharpProperty("Guid", "Id")
                        .SetDocBlock(new CSharpDocBlock("The unique identifier for this entity."))
                );

            if (!string.IsNullOrEmpty(recordSchema.Documentation))
                _ = @class.SetDocBlock(new CSharpDocBlock(recordSchema.Documentation));

            foreach (var field in recordSchema.Fields)
            {
                if (string.Equals(field.Name, "id", StringComparison.OrdinalIgnoreCase))
                    continue;

                var property = new CSharpProperty(AvroSchemaTypeParser.Parse(field, field.Type, Language.CSharp, Target.Entity), field.Name);

                string? propertyValue = field.Default?.ToObject<object>()?.ToString();
                if (!string.IsNullOrEmpty(propertyValue))
                    _ = property.SetValue(propertyValue);

                if (!string.IsNullOrEmpty(field.Documentation))
                    _ = property.SetDocBlock(new CSharpDocBlock(field.Documentation));

                _ = @class.AddProperty(property);
            }
            _ = compilation.AddType(@class);
        }
        return compilation;
    }
}
