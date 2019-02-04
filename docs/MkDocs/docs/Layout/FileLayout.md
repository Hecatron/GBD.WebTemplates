# File Layout

## C# Project Files


### appsettings.json / appsettings.Development.json

This file is a series of settings for the .net core application / site.
Typically it's settings such as what log level to use for warnings, or which connection strings to use for a database.

  * https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-2.1


### Global.json

This file allows to control which version of the .Net core SDK is in use

  * https://docs.microsoft.com/en-us/dotnet/core/tools/global-json


## Other Files

### .editorconfig

This file provides some generic information to multiple IDE's about the editing of files
such as the number of spaces to add as a tab or the type of newline to use

  * https://editorconfig.org/


### .gitignore

If the project / site is located within a git based source control repo.
this tells git which files it should ignore (such as bin) when tracking changes to the source code.

### .filenesting.json

This allows the customisation of nesting files within the ide view

  * https://blogs.msdn.microsoft.com/webdev/2018/02/07/file-nesting-in-solution-explorer/

## IIS Files

### Web.Config

This file can override settings for a given directory, typically used by IIS
