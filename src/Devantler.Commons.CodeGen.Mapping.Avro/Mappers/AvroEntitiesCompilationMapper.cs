using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Interfaces;

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
            Language.CSharp => AvroCSharpCompilationMapper.MapToCSharpEntities(rootSchema),
            _ => throw new NotSupportedException($"The language {language} is not supported.")
        };
    }
}
