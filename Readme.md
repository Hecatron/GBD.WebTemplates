# Readme

This is a series of web templates using some of the newer web technologies. <br>
At the moment the main frontend in use is Bootstrap4 but other frontends could be used instead

  * https://blogs.msdn.microsoft.com/webdev/2017/02/14/building-single-page-applications-on-asp-net-core-with-javascriptservices/

This is setup for use with Visual Studio 2017 / Visual Studio Code / Nodejs
(see docs on how to install nodejs via chocolatey)
See **Install.md** on how to set everything up

Backwards compatibility with old browsers can be a concern.
Bootstrap4 uses flexbox for it's grid so to get an idea of what browsers are compatible.

  * https://caniuse.com/#search=flexbox - Bootstrap 4


## Features

  * Debugging of typescript / javascript within Visual Studio
    It's now possible to add breakpoints / single step code for typescript / javascript within these templates.
    You'll ether need Visual Studio Code or Visual Studio 2017 for this to work, and use ether the Chrome or Edge browser.
    webpack handles generating sourcemaps behind the scenes to make this possible.

  * Single page Application
    Because of the use of vue when you navigate between pages there's no actual refresh of the page.
    The body switches across without the whole page refreshing which has a nicer and more responsive look.

  * Live editing / Hot reloading
    While running the site from VS2017 / VSCode if you make any changes to the CSS / JS / TS / client side code
    The page (should) auto refresh with the changes as the site is being debugged.
    The only time you might need to start / stop the debug session is when changing .net code

  * ASP .Net Core 2.2
    This is the latest incarnation of .Net that Microsoft are using including the next generation of MVC
    It's possible to connect to non-core libraries as long as the API is present in the original framework.

  * Webpack 4 - https://webpack.js.org/
    about twice as fast as webpack 2 / 3 and faster than most other bundlers such as gulp
    The one downside to webpack is it can be a bit difficult to configure, although I've taken care of that in these templates.
    It's faster than other bundlers, can do hot reloading, bundles as much as possible into single files to make the site load up faster.
    It also does handles the job of converting typescript to javascript / rendering scss to css files etc.

  * NPM / node_modules
    Typically using pnpm we can now download all the external javascript / css libs we want into a node_modules library.
    You just add what you want to the package.json file then run "pnpm install"
    These files are not checked into source control (which is good because the source can be huge)
    The site just pulls out / references what it wants from that directory.
    It also makes updating to newer versions as simple as changing a single line in package.json.
    or running "pnpm outdated" to see what newer versions are available.

  * Vuejs - https://vuejs.org/
    Vue allows us to create re-usable components, typicaly there are three parts, html (vue), script (ts / js), styles (scss / css)
    The html is actually templated inside a vue file so you can do things like for each loops or variable substitution.
    The script is setup for typescript currently and can manipulate the content of the vue file.
    The styles apply styling / css to the content of the vue files

  * Reactive components
    With vue files there's also an element of reactivness / event driven controls.
    So for example changing a lable in a vue file could trigger some other control to then change and so on in an event driven fasion.
    The controls can be re-used, so you could create a control for a single row in a table for example and use many of them within a parent control.
    It's similar in some respects to the old web forms aspx / aspx.vb layout except the code is client side.

  * Typescript - https://www.typescriptlang.org/
    Typescript is a language which is compiled / transpiled down to javascript.
    it makes life a bit easier for those more familiar with csharp / vb etc
    Normallly javascript allows you to put any value into a variable which can be a major headache when a string ends up in an int for example
    typescript prevents that sort of thing.
    It also allows for auto-completion and intelisense since it knows what the types are

  * Font Awesome Icons - https://fontawesome.com/icons?d=gallery&m=free

  * SCSS - https://sass-lang.com/
    SCSS is a language which is compiled down to CSS it allows for things like adding in variables for colours that can be used later on etc.
    It makes writing css a lot easier.


## Copying the project

If you want to copy / paste this project I'd ignore the following directories during the copy / paste
note these will also be excluded from git / source control

  * bin
  * node_modules
  * obj
