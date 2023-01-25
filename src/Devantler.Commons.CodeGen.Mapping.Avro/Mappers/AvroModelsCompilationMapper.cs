using Avro;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Interfaces;

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
            Language.CSharp => AvroCSharpCompilationMapper.MapToCSharpModels(rootSchema),
            _ => throw new NotSupportedException($"The language {language} is not supported.")
        };
    }
}
