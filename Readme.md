# Readme

This is a series of templates for use with .net core / Visual studio

  * https://survivejs.com/webpack/building/source-maps/
  * https://blogs.msdn.microsoft.com/webdev/2017/02/14/building-single-page-applications-on-asp-net-core-with-javascriptservices/
  * https://github.com/MarkPieszak/aspnetcore-Vue-starter
  * https://github.com/aspnet/Templating
  * https://github.com/aspnet/Templating/tree/muratg/vuejs/src/Microsoft.AspNetCore.SpaTemplates/content/Vue-CSharp
  * https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
  * https://natemcmaster.com/blog/2018/07/05/aspnetcore-hmr/

## Listing existing installed templates

To list all existing installed templates
```
dotnet new -l
```

## Templates

### ASPNet.Vue.BootStrap.v1

This is a version of the original vue / webpack template but updated to the latest npm packages.
and works with the debugging of typescript

### ASPNet.Vue.BootStrap.v2

For this version I've taken the code from ASPNet.Vue.BootStrap.v1
then added in the changes made under

https://github.com/MarkPieszak/aspnetcore-Vue-starter

TODO - update to bootstrap 4 - "bootstrap": "^4.1.3"
