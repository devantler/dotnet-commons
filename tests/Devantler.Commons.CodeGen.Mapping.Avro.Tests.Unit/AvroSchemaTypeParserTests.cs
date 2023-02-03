using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

public class AvroSchemaTypeParserTests
{
    [Theory, MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public void Parse_GivenValidFieldAndLanguage_ReturnsParsedValue(RecordField field, Language language, string expected)
    {
        // Act
        string actual = AvroSchemaTypeParser.Parse(field, field.Type, language);

        // Assert
        _ = actual.Should().Be(expected);
    }

    [Theory, MemberData(nameof(TestCases.InvalidCases), MemberType = typeof(TestCases))]
    public void Parse_GivenInvalidFieldOrLanguage_ThrowsNotSupportedException(RecordField field, Language language)
    {
        // Act
        Action actual = () => AvroSchemaTypeParser.Parse(field, field.Type, language);

        // Assert
        _ = actual.Should().Throw<NotSupportedException>();
    }
}
