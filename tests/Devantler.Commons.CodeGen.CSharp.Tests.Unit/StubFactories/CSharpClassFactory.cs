using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(CSharpClassOptions options, int index)
    {
        string? classDocumentation = options.IncludeDocumentation ? "Class documentation block" : null;
        var @class = new CSharpClass($"ClassName{index}", options.IncludeNamespace ? "Namespace" : "", classDocumentation);
        var @using = new CSharpUsing("System");
        _ = @class.AddImport(@using);

        if (options.IncludeImplementation)
        {
            var implementation = new CSharpInterface("IInterface", options.IncludeNamespace ? "Namespace" : "", null);
            _ = @class.AddImplementation(implementation);
        }

        for (int i = 0; i < options.FieldsCount; i++)
        {
            string? documentation = options.IncludeDocumentation ? $"Field documentation block {i}" : null;
            var field = new CSharpField(Visibility.Public, "string", $"FieldName{i}", "\"Hello World\"", documentation);
            _ = @class.AddField(field);
        }

        for (int i = 0; i < options.PropertiesCount; i++)
        {
            string? documentation = options.IncludeDocumentation ? $"Property documentation block {i}" : null;
            var property = new CSharpProperty(Visibility.Public, "string", $"Property{i}", "\"Hello World\"",
                documentation);
            _ = @class.AddProperty(property);
        }

        for (int i = 0; i < options.ConstructorsCount; i++)
        {
            var documentationBlock =
                options.IncludeDocumentation ? new CSharpDocBlock($"Constructor documentation block {i}") : null;
            var documentationParameter = new CSharpDocBlockParameter("parameterName", "a parameter");
            _ = documentationBlock?.AddParameter(documentationParameter);
            var constructor = new CSharpConstructor(Visibility.Public, "ClassName",
                "Console.WriteLine(\"Hello World!\");", documentationBlock);
            var parameter = new CSharpParameter("string", "parameterName");
            _ = constructor.AddParameter(parameter);
            _ = @class.AddConstructor(constructor);
        }

        for (int i = 0; i < options.MethodsCount; i++)
        {
            var documentationBlock = options.IncludeDocumentation ? new CSharpDocBlock($"Method documentation block {i}") : null;
            _ = documentationBlock?.AddParameter(new CSharpDocBlockParameter("parameterName", "a parameter"));
            var method = new CSharpMethod(Visibility.Public, "string", $"Method{i}",
                "Console.WriteLine(\"Hello World!\");", documentationBlock);
            _ = method.AddParameter(new CSharpParameter("string", "parameterName"));
            _ = @class.AddMethod(method);
        }

        return @class;
    }
}
