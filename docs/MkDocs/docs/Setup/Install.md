# Install

## Overview

In order to use / develop with this template I'd recommend the following

  * Visual Studio 2017 or Visual Studio Code
    updated to latest version (15.8.7 at the time of writing)

  * .Net Core SDK 2.2 - https://dotnet.microsoft.com/download

  * Chrome or the Edge browser

  * Typescript SDK 3.1
    https://www.microsoft.com/en-us/download/details.aspx?id=55258

It should be possible to debug the Typescript / Javascript in the IDE with ether VSCode or VStudio 2017.
I've setup a solution and vscode workspace file for both options in the src directory.

The vscode file templates.code-workspace should prompt for a list of recommended extensions to be installed when opened.


## Visual Studio 2017 Extensions

(some of these may end up being installed when the Typescript SDK is installed)

  * TypeScript Definition Generator
    https://marketplace.visualstudio.com/items?itemName=MadsKristensen.TypeScriptDefinitionGenerator

  * TypescriptSyntaxPaste
    https://marketplace.visualstudio.com/items?itemName=NhaBuiDuc.TypescriptSyntaxPaste

  * Vue js pack 2017
    https://marketplace.visualstudio.com/items?itemName=MadsKristensen.VuejsPack-18329

  * NPM Task runner
    https://marketplace.visualstudio.com/items?itemName=MadsKristensen.NPMTaskRunner

  * Sass Snippet Pack
    https://marketplace.visualstudio.com/items?itemName=clydedsouza.SassSnippetVsixExtension


## Node Modules

You will need to have nodejs / npm / (optionally pnpm) installed to use these templates
see NodeInstall.md

To setup the node_modules directory for a given template
```
pnpm install
```
