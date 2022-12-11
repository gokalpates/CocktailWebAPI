# CocktailWebAPI
Cocktail Web API and trivial frontend for school project.

## Structure

Project uses N-Tier Architecture with generic repository.

Solution has five projects which named as:

- Website : Front-end that communicates with backend (WebAPI Project) using HTTP. It is also main startup project of frontend.
- WebAPI : Backend's endpoint and main startup project of backend. 
- BusinessLayer : Backend's business layer.
- DataAccessLayer : Backend's data access layer.
- EntityLayer : Backend's entity layer.

## Dependencies

Project has multiple dependencies.

1. Microsoft Visual Studio Community 2022.
2. .NET Core 6.
3. SQL Server is used for database.
4. SQL Server Management Studio to faciliate database options.
5. Nuget Packages for Entity Framework Core: (Used for Code First approach and migrations.)
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.SqlServer (For SQL Server connection.)
    - Microsoft.EntityFrameworkCore.Tools

## How to build

- Download and install Visual Studio Community 2022 with ASP.NET and web development workload.
- Download and install Microsoft SQL Server.
- Download and install Microsoft SQL Server Management Studio.
- Open solution file.
- Alter Context's connection string under DataAccessLayer.
- EF Core must come with solution. But if somehow EF Core is not installed, then install them manually using Nuget Package Manager.
- Do initial migration(s) using package manager console.
- You are ready to go. If you want to add some default cocktails, then use sample objects in "SampleCocktails.txt" with SwaggerUI's post method.