// Vender EntryPoints

// Entrypoints define starting points for files to be brought into the packed destination.
// Anything referenced down the chain by these files will also be brought in

// If you just specify the directory
// then webpack will look at the named directory inside node_modules -> package.json -> The main field

var entrypoints = {
    vendor: [

        // Frontend
        'bootstrap/dist/js/bootstrap.js',
        'bootstrap/dist/css/bootstrap.css',
        'jquery',
        'popper.js',
        'metismenu/dist/metisMenu.js',
        'metismenu/dist/metisMenu.css',
        './ClientApp/css/fontawesome.scss',

        // Additional depends
        'event-source-polyfill',
        'isomorphic-fetch',

        // Vuejs related
        'vue',
        'vue-router'
    ]
};

exports.entrypoints = entrypoints;
