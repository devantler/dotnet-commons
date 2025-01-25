# 🪛 .NET Commons

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Test](https://github.com/devantler/dotnet-commons/actions/workflows/test.yaml/badge.svg)](https://github.com/devantler/dotnet-commons/actions/workflows/test.yaml)
[![codecov](https://codecov.io/gh/devantler/dotnet-commons/graph/badge.svg?token=RhQPb4fE7z)](https://codecov.io/gh/devantler/dotnet-commons)

<details>
  <summary>Show/hide folder structure</summary>

<!-- readme-tree start -->
```
.
├── .github
│   └── workflows
├── .vscode
├── src
│   ├── Devantler.Commons.AutoFixture.DataAttributes
│   └── Devantler.Commons.Extensions
│       └── StringExtensions
└── tests
    ├── Devantler.Commons.AutoFixture.DataAttributes.Tests.Unit
    └── Devantler.Commons.Extensions.Tests
        ├── EnumExtensionsTests
        ├── ListExtensionsTests
        ├── Setup
        │   ├── AutoDataAttributes
        │   └── SpecimenBuilders
        └── StringExtensions
            ├── CasingStringExtensionsTests
            ├── FormattingStringExtensionsTests
            ├── GeneralStringExtensionsTests
            └── GrammarStringExtensionsTests

21 directories
```
<!-- readme-tree end -->

</details>

A collection of libraries for .NET that provides common utilities.

## 🚀 Getting Started

To get started, you can install the packages from NuGet.

```bash
# Extensions for common classes and functionality for string, enum, list, etc.
dotnet add package Devantler.Commons.Extensions

# Automatic input for AutoFixture and xUnit
dotnet add package Devantler.Commons.AutoFixture.DataAttributes
```
