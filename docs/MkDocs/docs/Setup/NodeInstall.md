# Node install

## Install Chocolatey

In order to get access to npm on the command line we need to install NodeJs
One of the better ways to do this under windows is to use Chocolatey since it makes it easier to update later on

  * https://chocolatey.org/

  * Open up a command line prompt, use Right Click and "Run as administrator"
  * Copy / paste the below into the command line
```
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
```

## Install nodejs

Next we can install nodejs with
```
#Install:
choco install nodejs
#Update if already installed:
choco upgrade nodejs
```

## Install global npm packages

Nodejs includes npm as a package management for javascript
packages can be installed globally to the system or locally for a project (listed in package.json)
for local installs they end up in a node_modules directory inside the project
usually you exclude this directory from source control.

Some useful ones to install globally include
```
# Allows you to update npm with npm-windows-upgrade from the command line
npm install npm-windows-upgrade -g
# Compile scss to css files from the command line
npm install sass -g
npm install node-sass -g
# Similar to npm but installs local packages to a directory then creates links saving space on the disk
```

## Pnpm

  * https://medium.com/pnpm/pnpms-strictness-helps-to-avoid-silly-bugs-9a15fb306308
  * https://medium.com/pnpm/pnpm-version-2-is-out-a015268254d5

One of the main downsides to npm is the file space used by local installs.
Typically a website will have a file called package.json which lists all of the npm packages we want to use for the site.
When running "npm install" all of these packages will be downloaded and installed into a directory called node_modules

When you have a lot of sites this can use up a fair bit of space
One way around this is to use pnpm instead (which I recommend), it uses the same source for packages - https://www.npmjs.com/
pnpm downloads the files to a single directory then creates links on the filesystem to those files to avoid using up space

To install
```
npm install pnpm -g
```

### Visual Studio 2017 Setup

If we're using pnpm then we want to avoid running npm install whenever Visual Studio opens a project
Under Tools -> Options -> Projects and Solutions -> Web Package Management -> Package Restore

  * For NPM disable "Restore on open Project Option"
  * For NPM disable "Restore on Save"


## General Commands

To show outdated package that might need updating
```
# show any local packages that might be out of date
pnpm outdated
# Show any global packages that might be out of date
pnpm outdated -g
# List everything install globally
npm list -g --depth=0
```

## First time setup of a website

After downloading the source for the site from git, the first time before running you'll want to make sure
node_modules is populated
This will include things like javascript libraries / css libs etc from 3rd party vendors
```
cd src\AspNetCore.Vue.Bootstrap1
pnpm install
```
