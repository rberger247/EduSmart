# EduSmart

### Getting Started 

```
dotnet new angular -n ProjectName
cd projectName
npm Install
```

### Adding AngularCli To Project

[ Follow these Steps](https://www.codeproject.com/Tips/1208529/Angular-CLI-and-ASP-NET-Core-Angular-Template)

### Deploying To Azure

[Follow these steps](http://www.c-sharpcorner.com/article/build-angular-app-with-net-core-2-0-templatevs-2017-deploy-on-azure-step/)


### Working With Entity Framework in  .Net core 2.0


* install these three packages by typing into nugetPackage console:

```
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

* [Here are the steps you must follow](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db)
* add the following to .csProj file
```
<ItemGroup>
   <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
</ItemGroup>

```
