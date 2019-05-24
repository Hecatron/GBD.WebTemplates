# Notes

## Launching

running "electronize init" will add in needed configs
TODO launchSettings.json currently needs to be manually changed

running "electronize start" from the project root will start up the app

## Launch config change

Properties/launchSettings.json
updated to find electronize
if you call "dotnet electronize" then it looks for dotnet-electronize

## TODO

  * VS Publish currently doesn't bundle in electron to the output
  * Currently a random Typescript error on launch

we can launch manually via

cd D:\SourceCode\GitRepos\GBD.WebTemplates\src\AspNetCore\AspNetCore.Vue.Vuetify1.Electron\obj\Host
D:\SourceCode\GitRepos\GBD.WebTemplates\src\AspNetCore\AspNetCore.Vue.Vuetify1.Electron\obj\Host\node_modules\electron\dist\electron.exe .
