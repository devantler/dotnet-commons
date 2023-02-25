using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;
public static class CSharpClassFactory
{
    public static CSharpClass CreateCSharpClass(CSharpClassOptions options, int index)
    {
        var @class = new CSharpClass($"Class{index}")
            .SetVisibility(options.Visibility);

        if (options.IncludeNamespace)
            _ = @class.SetNamespace("Namespace");

        if (options.IncludeDocumentation)
            _ = @class.SetDocBlock(new CSharpDocBlock("Documentation"));

        if (options.IncludeUsing)
            _ = @class.AddImport(new CSharpUsing("System"));

        if (options.IsStatic)
            _ = @class.SetIsStatic(true);

        if (options.IsAbstract)
            _ = @class.SetIsAbstract(true);

        if (options.IsPartial)
            _ = @class.SetIsPartial(true);

        if (options.IncludeBaseClass)
            _ = @class.SetBaseClass(new CSharpClass("BaseClass").SetNamespace("BaseClassNamespace"));

        for (int i = 0; i < options.ImplementationOptions.Count; i++)
        {
            var implementation = new CSharpInterface($"ImplementedInterface{i}");

            for (int j = 0; j < options.ImplementationOptions.PropertyOptions.Count; j++)
            {
                _ = implementation.AddProperty(new CSharpProperty("string", $"Property{j}"));
            }
            _ = @class.AddImplementation(implementation);
        }

        for (int i = 0; i < options.FieldOptions.Count; i++)
        {
            var field = new CSharpField(options.FieldOptions.Nullables ? "string?" : "string", $"fieldName{i}")
                .SetVisibility(options.FieldOptions.Visibility);

            if (options.FieldOptions.IncludeValue)
                _ = field.SetValue("\"Hello World\"");

            if (options.FieldOptions.IncludeDocumentation)
                _ = field.SetDocBlock(new CSharpDocBlock($"Field documentation block {i}"));

            _ = @class.AddField(field);
        }

        for (int i = 0; i < options.ConstructorOptions.Count; i++)
        {
            var constructor = new CSharpConstructor($"Class{index}");

            if (options.ConstructorOptions.IncludeStatement)
                _ = constructor.AddStatement("Console.WriteLine(\"Hello World\");");

            if (options.ConstructorOptions.IncludeDocumentation)
            {
                _ = constructor.SetDocBlock(
                    new CSharpDocBlock($"Constructor documentation block {i}")
                        .AddParameter(new CSharpDocBlockParameter("param").SetDescription("a parameter")));
            }

            for (int j = 0; j < options.ConstructorOptions.ParameterOptions.Count; j++)
            {
                var parameter = new CSharpConstructorParameter("string", $"param{j}");

                if (options.ConstructorOptions.ParameterOptions.Nullables)
                    _ = parameter.SetIsNullable(true);

                if (options.IncludeBaseClass)
                    _ = parameter.SetIsBaseParameter(true);

                _ = constructor.AddParameter(parameter);
            }

            _ = @class.AddConstructor(constructor);
        }

        for (int i = 0; i < options.PropertyOptions.Count; i++)
        {
            var property = new CSharpProperty(options.PropertyOptions.Nullables ? "string?" : "string", $"Property{i}")
                .SetVisibility(options.PropertyOptions.Visibility);

            if (options.PropertyOptions.IncludeValue)
                _ = property.SetValue("\"Hello World\"");

            if (options.PropertyOptions.IncludeDocumentation)
                _ = property.SetDocBlock(new CSharpDocBlock($"Property documentation block {i}"));

            if (options.PropertyOptions.IsExpressionBodiedMembers)
                _ = property.SetIsExpressionBodiedMember(true);

            _ = @class.AddProperty(property);
        }

        for (int i = 0; i < options.MethodOptions.Count; i++)
        {
            var method = new CSharpMethod($"Method{i}")
                .SetVisibility(options.MethodOptions.Visibility)
                .SetReturnType(options.MethodOptions.ReturnType);

            if (options.MethodOptions.IncludeStatement)
            {
                _ = method.AddStatement("""Console.WriteLine("Hello World!");""")
                    .AddStatement("""return "Hello World!";""");
            }

            if (options.MethodOptions.IsPartial)
                _ = method.SetIsPartial(true);

            if (options.MethodOptions.IsStatic)
                _ = method.SetIsStatic(true);

            if (options.MethodOptions.IsExtensionMethod)
                _ = method.SetIsExtensionMethod(true);

            if (options.IncludeBaseClass)
                _ = method.SetIsOverride(true);

            if (options.MethodOptions.IncludeDocumentation)
            {
                _ = method.SetDocBlock(
                    new CSharpDocBlock($"Method documentation block {i}")
                        .AddParameter(new CSharpDocBlockParameter("param").SetDescription("a parameter"))
                );
            }

            for (int j = 0; j < options.MethodOptions.ParameterOptions.Count; j++)
            {
                var parameter = new CSharpParameter("string", $"param{j}");

                if (options.MethodOptions.ParameterOptions.Nullables)
                    _ = parameter.SetIsNullable(true);

                if (options.MethodOptions.ParameterOptions.HasDefaultValue)
                    _ = parameter.SetDefaultValue("\"Hello World\"");

                _ = method.AddParameter(parameter);
            }

            _ = @class.AddMethod(method);
        }

        return @class;
    }
}
