# Monday
## Welcome
- Intro
- Webcams on
- Not waste time
- Ask questions

## Install
https://builds.dotnet.microsoft.com/dotnet/install/dotnet_basic_config_docs.winget

1. The latest .NET SDK
2. Visual Studio Code editor
3. The C# DevKit

## Talk
- Back-End history
- When front and when back
    - Security
    - Reliability
    - Performance

## Hello World
https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-teleprompter

- DLL - dynamic link library: old Windows way of dependencies, .NET apps mostly use assemblies (MSIL, metadata, manifest)
- PDB - program database file: info for debugger

- String Interpolation
    - {DateTime.Now}
    - {DateTime.Now:MMMM d, yyyy}

## File I/O
https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-teleprompter

- Static
- IEnumerable
- <string>
- string?
- using - IDisposable
- var - implicitly typed local variable
- yield return - lazy evaluation: sequence generated on demand

## Features not Available in Java
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tips-for-java-developers

1. String interpolation
2. Nullable and non-nullable types
3. Pattern matching
4. async/await
5. LINQ

## Homework: REST Client 
https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient



# Tuesday
## Project types
- Multiple desktop
- Web
    - ASP
    - WebForms
    - MVC
    - Core MVC
    - Razor Pages
    - Blazor

## Razor Pages Web App
https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-9.0

### Get Started

"C:\Users\brian.koser\.dotnet\tools\dotnet-aspnet-codegenerator" razorpage -m Movie -dc RazorPagesMovie.Data.RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries --databaseProvider sqlite

### Add a model
Entity Framework is an Object-Relation Mapper

"C:\Users\brian.koser\.dotnet\tools\dotnet-ef" migrations add InitialCreate
"C:\Users\brian.koser\.dotnet\tools\dotnet-ef" database update

### Scaffolding

## Homework: finish Razor Pages demo



# Wednesday
## Advanced Features
### Consume API



# Thursday
## Project - Letterboxd clone
- TMDB API: https://www.themoviedb.org/login?to=read_me&redirect_uri=/docs



# Friday
Project demos
