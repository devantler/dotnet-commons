using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(CSharpClassOptions options, int index)
    {
        var @class = new CSharpClass($"ClassName{index}")
            .SetNamespace(options.IncludeNamespace ? "Namespace" : "");

        if (options.IncludeDocumentation)
            _ = @class.SetDocBlock(new CSharpDocBlock("Class documentation block"));

        var @using = new CSharpUsing("System");
        _ = @class.AddImport(@using);

        if (options.IncludeBaseClass)
            @class.BaseClass = new CSharpClass("BaseClass").SetNamespace("BaseClassNamespace");

        if (options.IncludeImplementation)
        {
            var implementation = new CSharpInterface("IInterface");

            if (options.IncludeNamespace)
                _ = implementation.SetNamespace("Namespace");

            _ = @class.AddImplementation(implementation);
        }

        for (int i = 0; i < options.FieldsCount; i++)
        {
            var field = new CSharpField(options.Nullables ? "string?" : "string", $"fieldName{i}")
                .SetValue("\"Hello World\"");

            if (options.IncludeDocumentation)
                _ = field.SetDocBlock(new CSharpDocBlock($"Field documentation block {i}"));

            _ = @class.AddField(field);
        }

        for (int i = 0; i < options.ConstructorsCount; i++)
        {
            var constructor = new CSharpConstructor("ClassName")
                .SetBody("Console.WriteLine(\"Hello World!\");");

            if (options.IncludeDocumentation)
            {
                _ = constructor.SetDocBlock(
                    new CSharpDocBlock($"Constructor documentation block {i}")
                        .AddParameter(new CSharpDocBlockParameter("parameterName").SetDescription("a parameter"))
                );
            }

            var parameter = new CSharpConstructorParameter("string", "parameterName");

            if (options.IncludeBaseClass)
                _ = parameter.SetIsBaseParameter(true);

            _ = constructor.AddParameter(parameter);
            _ = @class.AddConstructor(constructor);
        }

        for (int i = 0; i < options.PropertiesCount; i++)
        {
            var property = new CSharpProperty(options.Nullables ? "string?" : "string", $"Property{i}")
                .SetValue("\"Hello World\"");

            if (options.IncludeDocumentation)
                _ = property.SetDocBlock(new CSharpDocBlock($"Property documentation block {i}"));

            if (options.ExpressionBodiedMembers)
                _ = property.SetIsExpressionBodiedMember(true);

            _ = @class.AddProperty(property);
        }

        for (int i = 0; i < options.MethodsCount; i++)
        {
            var method = new CSharpMethod("string", $"Method{i}")
                .SetBody("Console.WriteLine(\"Hello World!\");");

            if (options.IncludeDocumentation)
            {
                _ = method.SetDocBlock(
                    new CSharpDocBlock($"Method documentation block {i}")
                        .AddParameter(new CSharpDocBlockParameter("parameterName").SetDescription("a parameter"))
                );
            }

            _ = method.AddParameter(new CSharpParameter("string", "parameterName"));
            _ = @class.AddMethod(method);
        }

        return @class;
    }
}
