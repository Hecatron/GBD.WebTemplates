# Sass / CSS

## Overview

One of the new features that web devs use is sass / less / stylus.
Sass or scss files seem to have become the more popular option.

What they are is basically a macro language which renders out css files for styling.
To give some examples you can specify a variable at the top of a certain colour, then re-use that variable throughout the scss files.
This way you only have to change the value in one place rather than a dozen or so places.

  * https://sass-lang.com/guide

Ultimatley the scss files are compiled down to css files before the webbrowser sees them.

## Installation

If we want to run sass from the command line for testing or to identify a problem.
I've found node-sass is better than sass for additional command line options and faster output.
Under the hood the sass-loader webpack uses I think uses node-sass as well.

To install globaly
```
npm install -g node-sass
```

To run

```
node-sass input.scss output.css
```

## Importing from node_modules

One of the problems people run into is that they want to import scss files from within node_modules
however sass currently doesn't have an official way to reference the node_modules directory (yet).

There is however a workaround.
With the sass-loader that webpack uses we can prefix the path with ~ such as

```
@import '~@fortawesome/fontawesome-free/scss/fontawesome';
```

This will work within sass-loader which webpack uses, but still presents a problem if you want to run node-sass from the command line
to test / figure out if there's a problem with your scss files.

To make this work at the command line we can install node-sass-package-importer

  * https://github.com/maoberlehner/node-sass-magic-importer/tree/master/packages/node-sass-package-importer

```
npm install node-sass-package-importer --save-dev
```

Then when running node-sass we need to pass in the importer option with a path to the importer
for example:
```
node-sass app.scss test1.css --importer ../../../node_modules/node-sass-package-importer/dist/cli.js
```
