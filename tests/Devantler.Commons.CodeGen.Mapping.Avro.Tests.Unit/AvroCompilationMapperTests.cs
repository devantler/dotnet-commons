using System.Text.Json;
using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

[UsesVerify]
public class AvroCompilationMapperTests
{
    [Theory]
    [MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public Task Map_WithValidSchema_ReturnsValidCompilation(Schema schema, Language language)
    {
        // Arrange
        var mapper = new AvroCompilationMapper();

        // Act
        var compilation = mapper.Map(schema, language);

        // Assert
        var options = new JsonSerializerOptions { WriteIndented = true };
        return Verify(JsonSerializer.Serialize(compilation, options)).UseMethodName(schema.Tag.ToString());
    }
}
