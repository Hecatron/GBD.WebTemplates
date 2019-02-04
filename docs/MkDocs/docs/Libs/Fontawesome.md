# Fontawesome

The included templates include support for fontawesome for different types of icons.
There's two different ways of using fontawesome icons

  * The first method involves css / the use of font files such as fa-regular-400.ttf.
  * The second method involves vue components / js which uses svg based icons instead.

## Font Files / CSS

### Install

For the first method make sure the following line is within webpack.config.vendor.js
under the entry points

```
var entrypoints = {
  vendor: [
    './ClientApp/vendor/fontawesome/cssfontfiles.scss',
  ]
}
```

This will pull in the scss file which in turn references a bunch of different icons sets
under node_modules/@fortawesome/fontawesome-free/scss/
The end result will be a bunch of font files installed to wwwroot\dist\fonts
once the webpack file is run.

### Use

To use these font files we can use a block of css / scss which looks something like this:

```
.multilevel-accordion-menu .is-accordion-submenu-parent[aria-expanded="false"] a {
    &::before {
        font-family: 'Font Awesome 5 Free';
        font-weight: 900;
        content: "\f07b";
        margin-right: 1rem;
    }
}
```

## SVG / Vue Components / JS

### Install

This method of using font awesome is a little different and involves javascript / typescript instead of css.
This should allow you to put font icons into the vue template as they're own component.

Within ClientApp/common/boot.ts
we need to run the svgicons.ts file, this can be customised to select which icons should be available

```
// This will bring in the svg files for fontawesome
import setup_icons from "./svgicons";
setup_icons();
```

### Usage

Next edit the svgicon.ts file to add in which icons you want
There are two places to add icons into in the file

```
// See https://fontawesome.com/icons?d=gallery for all icons
import { faBars, faCog, faFile, faFolder, faFolderOpen, faSpinner } from "@fortawesome/free-solid-svg-icons";
```

```
library.add(faBars, faSpinner, faCog, faFolder, faFolderOpen, faFile);
```

To place an icon within the html / vue
```
<fa-icon icon="cog"></fa-icon>
```
