using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(int numberOfFields, int numberOfProperties, int numberOfConstructors, int numberOfMethods, bool withDocumentation)
    {
        var @class = new CSharpClass("ClassName", "Namespace", withDocumentation ? "Class documentation block" : null);

        _ = @class.AddUsing("System");

        for (int i = 0; i < numberOfFields; i++)
        {
            _ = @class.AddMember(new CSharpField(Visibility.Public, "string", $"FieldName{i}", "\"Hello World\"", withDocumentation ? $"Field documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfProperties; i++)
        {
            _ = @class.AddMember(new CSharpProperty(Visibility.Public, "string", $"Property{i}", "\"Hello World\"", withDocumentation ? $"Property documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfConstructors; i++)
        {
            _ = @class.AddMember(new CSharpConstructor(Visibility.Public, "ClassName", "Console.WriteLine(\"Hello World!\");", withDocumentation ? new CSharpDocumentationBlock($"Constructor documentation block {i}") : null));
        }

        for (int i = 0; i < numberOfMethods; i++)
        {
            _ = @class.AddMember(new CSharpMethod(Visibility.Public, "string", $"Method{i}", "Console.WriteLine(\"Hello World!\");", withDocumentation ? new CSharpDocumentationBlock($"Method documentation block {i}") { Parameters = new List<string> { "parameterName" } } : null) { Parameters = new List<ParameterBase> { new CSharpParameter("string", "parameterName") } });
        }

        return @class;
    }
}
