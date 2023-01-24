using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(int numberOfFields, int numberOfProperties, int numberOfConstructors,
        int numberOfMethods, bool hasNamespaces, bool withDocumentation, bool? hasImplementation = null)
    {
        string? classDocumentation = withDocumentation ? "Class documentation block" : null;
        var @class = new CSharpClass("ClassName", hasNamespaces ? "Namespace" : "", classDocumentation);
        var @using = new CSharpUsing("System");
        _ = @class.AddImport(@using);

        if (hasImplementation == true)
        {
            var implementation = new CSharpInterface("IInterface", hasNamespaces ? "Namespace" : "", null);
            _ = @class.AddImplementation(implementation);
        }

        for (int i = 0; i < numberOfFields; i++)
        {
            string? documentation = withDocumentation ? $"Field documentation block {i}" : null;
            var field = new CSharpField(Visibility.Public, "string", $"FieldName{i}", "\"Hello World\"", documentation);
            _ = @class.AddField(field);
        }

        for (int i = 0; i < numberOfProperties; i++)
        {
            string? documentation = withDocumentation ? $"Property documentation block {i}" : null;
            var property = new CSharpProperty(Visibility.Public, "string", $"Property{i}", "\"Hello World\"",
                documentation);
            _ = @class.AddProperty(property);
        }

        for (int i = 0; i < numberOfConstructors; i++)
        {
            var documentationBlock =
                withDocumentation ? new CSharpDocBlock($"Constructor documentation block {i}") : null;
            var documentationParameter = new CSharpDocBlockParameter("parameterName", "a parameter");
            _ = documentationBlock?.AddParameter(documentationParameter);
            var constructor = new CSharpConstructor(Visibility.Public, "ClassName",
                "Console.WriteLine(\"Hello World!\");", documentationBlock);
            var parameter = new CSharpParameter("string", "parameterName");
            _ = constructor.AddParameter(parameter);
            _ = @class.AddConstructor(constructor);
        }

        for (int i = 0; i < numberOfMethods; i++)
        {
            var documentationBlock = withDocumentation ? new CSharpDocBlock($"Method documentation block {i}") : null;
            _ = documentationBlock?.AddParameter(new CSharpDocBlockParameter("parameterName", "a parameter"));
            var method = new CSharpMethod(Visibility.Public, "string", $"Method{i}",
                "Console.WriteLine(\"Hello World!\");", documentationBlock);
            _ = method.AddParameter(new CSharpParameter("string", "parameterName"));
            _ = @class.AddMethod(method);
        }

        return @class;
    }
}
