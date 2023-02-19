using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpInterfaceFactory
{
    public static CSharpInterface CreateCSharpInterface(CSharpInterfaceOptions options, int index)
    {
        var @interface = new CSharpInterface($"InterfaceName{index}")
            .SetNamespace(options.IncludeNamespace ? "Namespace" : "");

        if (options.IncludeDocumentation)
            _ = @interface.SetDocBlock(new CSharpDocBlock("Interface documentation block"));

        _ = @interface.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < options.PropertiesCount; i++)
        {
            var property = new CSharpProperty(options.Nullables ? "string?" : "string", $"Property{i}")
                    .SetValue("\"Hello World\"");

            if (options.IncludeDocumentation)
                _ = property.SetDocBlock(new CSharpDocBlock($"Property documentation block {i}"));

            if (options.ExpressionBodiedMembers)
                _ = property.SetIsExpressionBodiedMember(true);

            _ = @interface.AddProperty(property);
        }

        for (int i = 0; i < options.MethodsCount; i++)
        {
            var method = new CSharpMethod("string", $"Method{i}")
                .SetBody("Console.WriteLine(\"Hello World!\");")
                .AddParameter(new CSharpParameter("string", "parameterName"));

            if (options.IncludeDocumentation)
            {
                _ = method.SetDocBlock(
                    new CSharpDocBlock($"Method documentation block {i}")
                        .AddParameter(new CSharpDocBlockParameter("parameterName")));
            }
            _ = @interface.AddMethod(method);
        }

        return @interface;
    }
}
