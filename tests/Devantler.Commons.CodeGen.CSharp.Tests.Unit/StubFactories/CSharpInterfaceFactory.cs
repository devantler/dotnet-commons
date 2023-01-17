using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpInterfaceFactory
{
    public static CSharpInterface CreateCSharpInterface(int numberOfProperties, int numberOfMethods,
        bool withDocumentation)
    {
        var @interface = new CSharpInterface("InterfaceName", "Namespace",
            withDocumentation ? "Interface documentation block" : null);

        _ = @interface.AddImport(new CSharpUsing("System"));

        for (int i = 0; i < numberOfProperties; i++)
        {
            _ = @interface.AddProperty(new CSharpProperty(Visibility.Public, "string", $"Property{i}",
                "\"Hello World\"", withDocumentation ? $"Property documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfMethods; i++)
        {
            var documentationBlock = (withDocumentation ? new CSharpDocBlock($"Method documentation block {i}") : null)?
                .AddParameter(new CSharpDocBlockParameter("parameterName"));
            var method = new CSharpMethod(Visibility.Public, "string", $"Method{i}",
                    "Console.WriteLine(\"Hello World!\");", documentationBlock)
                .AddParameter(new CSharpParameter("string", "parameterName"));
            _ = @interface.AddMethod(method);
        }

        return @interface;
    }
}
