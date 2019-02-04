# Webpack

## Overview

With these projects there are two main webpack files

  * The vendor webpack file - **webpack.config.vendor.js**
    This brings in content such as css or js from 3rd party libraries
    The idea is this content doesn't change while developing so contains the large heavyweight stuff

  * The non vendor webpack file - **webpack.config.js**
    This file references javascript that's local to the site and could change during development.

By keeping the larger js / css within a seperate vendor file this allows us to more quickly
re-generate the content on the site into a bundle on it's own

## HMR - Hot Module Replacement

With the current setup any changes to the css / js / ts / scss / client side code
while running the site will automatically trigger an update / refresh of the page

  * https://natemcmaster.com/blog/2018/07/05/aspnetcore-hmr/

### Manually running webpack

Sometimes it's good to run webpack at the command line manually to find errors <br/>
In order to do this we can use:
```
node node_modules/webpack/bin/webpack.js --config webpack.config.js --mode=development
node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js --mode=development
```
