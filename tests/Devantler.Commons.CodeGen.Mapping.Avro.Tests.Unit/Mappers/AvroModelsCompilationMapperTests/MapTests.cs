using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.Mappers.AvroModelsCompilationMapperTests;

/// <summary>
/// Tests for <see cref="AvroModelsCompilationMapper"/>.
/// </summary>
[UsesVerify]
public class MapTests
{
    /// <summary>
    /// Tests the <see cref="AvroModelsCompilationMapper.Map"/> method.
    /// </summary>
    /// <param name="schema"></param>
    /// <param name="language"></param>
    [Theory]
    [MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public Task GivenValidSchema_ReturnsValidCompilation(Schema schema, Language language)
    {
        // Arrange
        var mapper = new AvroModelsCompilationMapper();

        // Act
        var compilation = mapper.Map(schema, language);

        // Assert
        return Verify(compilation).UseMethodName(schema.GetType().Name);
    }

    /// <summary>
    /// Tests for <see cref="AvroModelsCompilationMapper.Map"/> method.
    /// </summary>
    [Fact]
    public void GivenUnsupportedLanguage_ThrowsNotSupportedException()
    {
        // Arrange
        const Language language = (Language)999;
        var mapper = new AvroModelsCompilationMapper();

        // Act
        var schemaBuilder = new SchemaBuilder();
        CodeGen.Core.Model.ICompilation action() => mapper.Map(schemaBuilder.BuildSchema<RecordSchema>(), language);

        // Assert
        _ = Assert.Throws<NotSupportedException>((Func<CodeGen.Core.Model.ICompilation>)action);
    }
}
