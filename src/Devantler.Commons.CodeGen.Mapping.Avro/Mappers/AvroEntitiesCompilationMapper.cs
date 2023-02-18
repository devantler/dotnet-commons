using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;
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

            CSharpClass @class = new($"{recordSchema.Name}Entity", recordSchema.Namespace, recordSchema.Documentation);

            @class.AddProperty(new CSharpProperty(Visibility.Public, "Guid", "Id", documentation: "The unique identifier of the entity."));
            foreach (var field in recordSchema.Fields)
            {
                if (string.Equals(field.Name, "id", StringComparison.OrdinalIgnoreCase))
                    continue;

                _ = @class.AddProperty(field, Target.Entity);
            }
            _ = compilation.AddClass(@class);
        }
        return compilation;
    }
}
