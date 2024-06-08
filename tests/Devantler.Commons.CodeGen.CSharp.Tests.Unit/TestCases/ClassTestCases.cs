using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.TestCases;

/// <summary>
/// Test cases for C# class generation.
/// </summary>
public static class ClassTestCases
{
  /// <summary>
  /// Valid test cases.
  /// </summary>
  public static IEnumerable<object[]> ValidCases =>
    [
      [
          "EmptyClass",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => classOptions.Count = 1
          )
      ],
      [
          "ClassWithUsing",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeUsing = true;
              }
          )
      ],
      [
          "ClassWithBaseClass",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeBaseClass = true;
              }
          )
      ],
      [
          "ClassWithBaseClassAndImplementation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeBaseClass = true;
                  classOptions.ImplementationOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithNonDefaultVisibility",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.Visibility = Visibility.Private;
              }
          )
      ],
      [
          "PartialClass",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IsPartial = true;
              }
          )
      ],
      [
          "PartialClassWithPartialMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IsPartial = true;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IsPartial = true;
              }
          )
      ],
      [
          "AbstractClass",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IsAbstract = true;
              }
          )
      ],
      [
          "StaticClass",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IsStatic = true;
              }
          )
      ],
      [
          "ClassWithDocumentation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeDocumentation = true;
              }
          )
      ],
      [
          "ClassWithNamespace",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeNamespace = true;
              }
          )
      ],
      [
          "ClassWithField",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.FieldOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithFieldAndNonDefaultVisibility",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.FieldOptions.Count = 1;
                  classOptions.FieldOptions.Visibility = Visibility.Private;
              }
          )
      ],
      [
          "ClassWithNullableField",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.FieldOptions.Count = 1;
                  classOptions.FieldOptions.Nullables = true;
              }
          )
      ],
      [
          "ClassWithFieldAndValue",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.FieldOptions.Count = 1;
                  classOptions.FieldOptions.IncludeValue = true;
              }
          )
      ],
      [
          "ClassWithFieldAndDocumentation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.FieldOptions.Count = 1;
                  classOptions.FieldOptions.IncludeDocumentation = true;
              }
          )
      ],
      [
          "ClassWithProperty",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithNullableProperty",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
                  classOptions.PropertyOptions.Nullables = true;
              }
          )
      ],
      [
          "ClassWithPropertyAndNonDefaultVisibility",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
                  classOptions.PropertyOptions.Visibility = Visibility.Private;
              }
          )
      ],
      [
          "ClassWithPropertyAndDocumentation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
                  classOptions.PropertyOptions.IncludeDocumentation = true;
              }
          )
      ],
      [
          "ClassWithPropertyAndValue",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
                  classOptions.PropertyOptions.IncludeValue = true;
              }
          )
      ],
      [
          "ClassWithPropertyAndExpressionBodiedMember",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.PropertyOptions.Count = 1;
                  classOptions.PropertyOptions.IncludeValue = true;
                  classOptions.PropertyOptions.IsExpressionBodiedMembers = true;
              }
          )
      ],
      [
          "ClassWithImplementation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ImplementationOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithImplementationAndProperties",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ImplementationOptions.Count = 1;
                  classOptions.ImplementationOptions.PropertyOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithConstructor",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithConstructorAndNonDefaultVisibility",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.Visibility = Visibility.Protected;
              }
          )
      ],
      [
          "ClassWithConstructorAndStatement",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.IncludeStatement = true;
              }
          )
      ],
      [
          "ClassWithConstructorAndDocumentation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.IncludeDocumentation = true;
              }
          )
      ],
      [
          "ClassWithConstructorAndParameter",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithConstructorAndNullableParameter",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.Nullables = true;
              }
          )
      ],
      [
          "ClassWithConstructorAndBaseParameter",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeBaseClass = true;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithConstructorAndBaseParameterWithCustomName",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeBaseClass = true;
                  classOptions.ConstructorOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.Count = 1;
                  classOptions.ConstructorOptions.ParameterOptions.BaseParameterName = "baseParameter";
              }
          )
      ],
      [
          "ClassWithMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithStaticMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IsStatic = true;
              }
          )
      ],
      [
          "ClassWithExtensionMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.Count = 2;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IsExtensionMethod = true;
              }
          )
      ],
      [
          "ClassWithMethodAndNonDefaultVisibility",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.Visibility = Visibility.Private;
              }
          )
      ],
      [
          "ClassWithMethodAndAttribute",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IncludeAttribute = true;
              }
          )
      ],
      [
          "ClassWithMethodAndStatement",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IncludeStatement = true;
              }
          )
      ],
      [
          "ClassWithExpressionBodiedMethodAndStatement",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IncludeStatement = true;
                  classOptions.MethodOptions.IsExpressionBodied = true;
              }
          )
      ],
      [
          "ClassWithAsynchronousMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IsAsynchronous = true;
              }
          )
      ],
      [
          "ClassWithMethodAndDocumentation",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.IncludeDocumentation = true;
              }
          )
      ],
      [
          "ClassWithMethodAndNonDefaultReturnType",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.ReturnType = "object";
              }
          )
      ],
      [
          "ClassWithMethodAndOverriddenMethod",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.IncludeBaseClass = true;
                  classOptions.MethodOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithMethodAndParameter",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.Count = 1;
              }
          )
      ],
      [
          "ClassWithMethodAndNullableParameter",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.Nullables = true;
              }
          )
      ],
      [
          "ClassWithMethodAndParameterWithDefaultValue",
          CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
              classOptionsAction: classOptions => {
                  classOptions.Count = 1;
                  classOptions.MethodOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.Count = 1;
                  classOptions.MethodOptions.ParameterOptions.HasDefaultValue = true;
              }
          )
      ]
    ];

  /// <summary>
  /// Invalid test cases.
  /// </summary>
  public static IEnumerable<object[]> InvalidCases => [];
}
