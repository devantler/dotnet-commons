using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

[UsesVerify]
public class AvroCompilationMapperTests
{
    [Theory]
    [MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public Task Map_GivenValidSchema_ReturnsValidCompilation(Schema schema, Language language)
    {
        // Arrange
        var mapper = new AvroCompilationMapper();

        // Act
        var compilation = mapper.Map(schema, language);

        // Assert
        return Verify(compilation).UseMethodName(schema.Tag.ToString());
    }

    [Fact]
    public void Map_GivenUnsupportedLanguage_ThrowsNotSupportedException()
    {
        // Arrange
        const Language language = (Language)999;
        var mapper = new AvroCompilationMapper();

        // Act
        var action = () => mapper.Map(RecordSchema.Create("EmptyShema", new List<Field>()), language);

        // Assert
        _ = action.Should().Throw<NotSupportedException>();
    }
}
