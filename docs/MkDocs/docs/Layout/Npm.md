# Npm

## Overview

  * https://nodesource.com/blog/eleven-npm-tricks-that-will-knock-your-wombat-socks-off/

## Updating packages

One advantage to nodejs / npm is that it can be very quick to update to newer versions of javascript libs.

  * run "pnpm outdated" to show potential updates
  * update the package.json file to the new version
  * run "pnpm install" to install the new versions

Typically there are two locations where the names and versions of packages are in use are stored

  * package.json - user provided names and versions of js libs required
  * package-lock.json (npm) or shrinkwrap.yaml (pnpm) which is a more detailed list of packages used (auto generated)

If you come across a npm-shrinkwrap.json file, this is a legacy / old form of package-lock.json from eariler versions of npm


Note you need to be careful when updating npm packages to newer versions
as sometimes the API's can change with large version number changes or there can be unexpected glitches.


## Cleanup node_modules

Sometimes if your having random typescript or other problems it's best to try and reset the node_modules directory on the disk for the site
to do this

  * close Visual Studio
  * delete the obj directory which is a temp build directory
  * delete node_modules
  * delete package-lock.json / shrinkwrap.yaml
  * start the developer 2017 command line, using run as administrator
  * run "pnpm install" within the project directory
  * this should regenerate the node_modules directory and package-lock.json / shrinkwrap.yaml
  * restart visual studio
