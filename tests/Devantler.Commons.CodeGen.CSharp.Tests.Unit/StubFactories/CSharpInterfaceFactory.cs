using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

public static class CSharpInterfaceFactory
{
    public static CSharpInterface CreateCSharpInterface(int numberOfProperties, int numberOfMethods, bool withDocumentation)
    {
        var @interface = new CSharpInterface("InterfaceName", "Namespace", withDocumentation ? "Interface documentation block" : null);

        _ = @interface.AddUsing("System");

        for (int i = 0; i < numberOfProperties; i++)
        {
            _ = @interface.AddMember(new CSharpProperty(Visibility.Public, "string", $"Property{i}", "\"Hello World\"", withDocumentation ? $"Property documentation block {i}" : null));
        }

        for (int i = 0; i < numberOfMethods; i++)
        {
            _ = @interface.AddMember(new CSharpMethod(Visibility.Public, "string", $"Method{i}", "Console.WriteLine(\"Hello World!\");", withDocumentation ? new CSharpDocumentationBlock($"Method documentation block {i}") { Parameters = new List<string> { "parameterName" } } : null) { Parameters = new List<ParameterBase> { new CSharpParameter("string", "parameterName") } });
        }

        return @interface;
    }
}
