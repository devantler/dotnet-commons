using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

public class AvroSchemaTypeParserTests
{
    [Theory, MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public void GivenValidSchema_ReturnsValidType(Field field, Language language, string expected)
    {
        // Act
        string actual = AvroSchemaTypeParser.Parse(field, field.Schema.Tag, language);

        // Assert
        _ = actual.Should().Be(expected);
    }
}
