# Typescript

## Overview

  * https://blog.kloud.com.au/2017/02/24/writing-vuejs-apps-in-typescript-on-aspnet-core/
  * https://www.npmjs.com/package/vue-typescript-import-dts
  * https://alligator.io/vuejs/typescript-class-components/

Typescript is a language that is compiled down to javascript.
It has a couple of benifits over regular javascript

  * It's statically typed, this means if you try to put a string into a variable assigned as a string an error will result.
    Typically with js it doesn't really care about the types of variables which can lead to a lot of interesting and difficult to find problems.
  * Because the types are known Visual Studio is able to do intelisense / auto completion on the code as it's being written.
  * There are certain shortcuts to the code which make it nicer to look at.

Typically typescript is good for folks that are used to .net code since it has a similar syntax with it's class declerations.
Although since the code is compiled down to JS it's all run client side.

A good way to test things is a basic alert in the code
```
alert("greeting2: ");
```

If your using Chrome or MS Edge browser you should be able to set breakpoints within Visual Studio 2017 / Visual Studio Code
However I've noticed sometimes that I need to toggle a breakpoint off / on after the site as been set running for the breakpoint to be hit
It's usually the case if the page is refreshed during a debug session, or on a calling function after an emit within Vue

  * https://developercommunity.visualstudio.com/content/problem/125941/typescript-debugging-is-not-working-on-visual-stud.html


## Sourcemaps

  * https://survivejs.com/webpack/building/source-maps/

One thing to be aware of is source maps.
With Typescript it's first compiled into javascript, then after that it's then packed into a single file by webpack.
There needs to be some way for the browser to indicate back to the IDE where it's point is in the code.
Source maps provide this, they map lines in the running code back to lines in the development code base.

The webpack configuration settings for these template should already be setup to generate the needed source maps automatically.

## Links


### General Typescript

  * https://decembersoft.com/posts/say-goodbye-to-relative-paths-in-typescript-imports/


### Vue Related

  * https://frontendsociety.com/writing-single-file-components-vue-files-in-typescript-vue-class-component-vs-vue-extend-c5c1d8e47b7
  * https://alligator.io/vuejs/typescript-class-components/
  * https://frontendsociety.com/using-a-typescript-interfaces-and-types-as-a-prop-type-in-vuejs-508ab3f83480
  * https://alligator.io/vuejs/global-event-bus/
  * https://forum.vuejs.org/t/vue2-webpack-foundation6-integration/170/2
  * https://medium.com/@tommaso.marcelli/setting-up-vue-2-and-foundation-6-3f858b4ad20


  * https://blog.mariusschulz.com/2016/11/25/typescript-2-0-built-in-type-declarations
  * https://basarat.gitbooks.io/typescript/docs/types/lib.d.ts.html
  * https://alligator.io/vuejs/typescript-class-components/
  * https://www.thepolyglotdeveloper.com/2018/04/access-change-parent-variables-child-component-vuejs/
