<!-- Icon here -->

# CopyObject
CopyObject is a object-to-object mapping dotnet library that can be used to map objects belonging to dissimilar types

## Build Status

Appveyor
:-:
[![Build status][ai]][al]
<!-- a and c are the first letter of CI plugins. i is icon and l is link. -->

[ai]: https://ci.appveyor.com/api/projects/status/efju4g16n15iwgq1?svg=true
[al]: https://ci.appveyor.com/project/tanbirhossain/copyobject

## NuGet Package

[![](https://img.shields.io/nuget/v/CopyObject.svg)](https://www.nuget.org/packages/CopyObject)

## Getting Started

### Packing a source NuGet package

Using NuGet tool to install [CopyObject](https://www.nuget.org/packages/CopyObject/) to your project

```
PM> Install-Package CopyObject
```

Or

```
dotnet add package CopyObject
```
## How to use ?
```
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            User userEntity = new User() { Id = 1, Name = "Ovi", DOB = DateTime.UtcNow };
            UserVM userVM = new UserVM();
            userVM.CopyObjectFrom(userEntity);
        }
    }
}
```
