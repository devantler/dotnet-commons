using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Mapping.Avro.Mappers;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.Mappers.AvroModelsCompilationMapperTests;

[UsesVerify]
public class MapTests
{
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

    [Fact]
    public void GivenUnsupportedLanguage_ThrowsNotSupportedException()
    {
        // Arrange
        const Language language = (Language)999;
        var mapper = new AvroModelsCompilationMapper();

        // Act
        var schemaBuilder = new SchemaBuilder();
        var action = () => mapper.Map(schemaBuilder.BuildSchema<RecordSchema>(), language);

        // Assert
        _ = action.Should().Throw<NotSupportedException>();
    }
}
