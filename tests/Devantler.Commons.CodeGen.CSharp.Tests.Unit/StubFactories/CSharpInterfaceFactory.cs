using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories.Options;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpInterfaceFactory
{
    public static CSharpInterface CreateCSharpInterface(CSharpInterfaceOptions options, int index)
    {
        var @interface = new CSharpInterface($"Interface{index}")
            .SetVisibility(options.Visibility);

        if (options.IncludeNamespace)
            _ = @interface.SetNamespace("Namespace");

        if (options.IncludeDocumentation)
            _ = @interface.SetDocBlock(new CSharpDocBlock("Documentation"));

        if (options.IncludeUsing)
            _ = @interface.AddImport(new CSharpUsing("System"));

        if (options.IsPartial)
            _ = @interface.SetIsPartial(true);

        for (int i = 0; i < options.ImplementationOptions.Count; i++)
        {
            var implementation = new CSharpInterface($"ImplementedInterface{i}");

            for (int j = 0; j < options.ImplementationOptions.PropertyOptions.Count; j++)
            {
                _ = implementation.AddProperty(new CSharpProperty("string", $"Property{j}"));
            }
            _ = @interface.AddImplementation(implementation);
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

            _ = @interface.AddProperty(property);
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

                _ = method.AddParameter(parameter);
            }

            _ = @interface.AddMethod(method);
        }

        return @interface;
    }
}
