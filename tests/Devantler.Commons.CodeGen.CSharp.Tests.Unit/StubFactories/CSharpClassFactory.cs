using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(int numberOfFields, int numberOfProperties, int numberOfConstructors, int numberOfMethods, bool withDocumentation)
    {
        var @class = new CSharpClass("ClassName", "Namespace", withDocumentation ? "Class documentation block" : null);

        _ = @class.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < numberOfFields; i++)
        {
            _ = @class.AddField(new CSharpField(Visibility.Public, "string", $"FieldName{i}", "\"Hello World\"", withDocumentation ? $"Field documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfProperties; i++)
        {
            _ = @class.AddProperty(new CSharpProperty(Visibility.Public, "string", $"Property{i}", "\"Hello World\"", withDocumentation ? $"Property documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfConstructors; i++)
        {
            _ = @class.AddConstructor(new CSharpConstructor(Visibility.Public, "ClassName", "Console.WriteLine(\"Hello World!\");", withDocumentation ? new CSharpDocBlock($"Constructor documentation block {i}") : null));
        }

        for (int i = 0; i < numberOfMethods; i++)
        {
            CSharpDocBlock? documentationBlock = withDocumentation ? new CSharpDocBlock($"Method documentation block {i}") : null;
            _ = (documentationBlock?.AddParameter(new CSharpDocBlockParameter("parameterName", "a parameter")));
            var method = new CSharpMethod(Visibility.Public, "string", $"Method{i}", "Console.WriteLine(\"Hello World!\");", documentationBlock);
            _ = method.AddParameter(new CSharpParameter("string", "parameterName"));
            _ = @class.AddMethod(method);
        }

        return @class;
    }
}
