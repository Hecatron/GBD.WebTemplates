# Webpack Loaders

## Overview

Loaders are only used if an entrypoint file or a file included / referenced by an entrypoint
references a file with a given extension that matches a loader pattern in the list of rules.

If for example a javascript file that's been brought in references a .gif file and there's a rule
present for .gif files then the given loader will be called.


## General Loaders

### file-loader

File load is a simple loader for bringing files into the site distribution

  * https://webpack.js.org/loaders/file-loader/

```
{ test: /\.(jpg|png)$/, use: {
    loader: "file-loader",
    options: {
      name: "[path][name].[hash].[ext]",
    },
  },
},
```

### url-loader

Url loader can be used to inline images or other files into the javascript.
The general idea being that for lots of smaller images it can reduce the load time for a website

The limit option can be used to determine the maximum size of the file before it's included into the site
as a seperate file rather than a inline.
The same options for file-loader can be used for url-loader

  * https://webpack.js.org/loaders/url-loader/
  * https://survivejs.com/webpack/loading/images/

### vue-loader

The vue-loader is used for handling vue files
These are re-useable components / (blocks of html / js / css)

  * https://vue-loader.vuejs.org/guide/
  * https://github.com/vuejs/vue-loader


## Style loaders

### style-loader

Normally style-loader is used in combination with css-loader
also we normally we use it for development instead of production

  * https://github.com/webpack-contrib/style-loader

  * css-loader bundles / brings in css file into the javascript bundle file
  * style-loader then applies those styles to the html inline (without linking to an external file) at the head of the page

For development we put all the css into the javascript file with style-loader
but for production we instead use a different approach with extract-css-chunks-webpack-plugin to bundle all the css into a seperate css file


TODO
Styles are not added on import/require(), but instead on call to use/ref.
Styles are removed from page if unuse/unref is called exactly as often as use/ref

```
import style from './file.css'

style.use(); // = style.ref();
style.unuse(); // = style.unref();
```

### extract-css-chunks-webpack-plugin

TODO

### vue-style-loader

This loader is a modified version of style-loader
typically when a style is imported for the vue control it is auto applied

  * https://github.com/vuejs/vue-style-loader

