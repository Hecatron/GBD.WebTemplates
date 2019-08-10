// Site webpack config
// This file typically brings in any css / js that's unique to the site / is rebuilt often or live.

// Standard imports
const path = require('path');
const webpack = require('webpack');
const bundleOutputDir = './wwwroot/dist';
var isDevBuild = true;

// Plugins
const ExtractCssChunks = require('extract-css-chunks-webpack-plugin');
const TerserPlugin = require('terser-webpack-plugin');
const OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');
const { VueLoaderPlugin } = require('vue-loader');
const ForkTsCheckerWebpackPlugin = require('fork-ts-checker-webpack-plugin');

// Entrypoints define starting points for files to be brought into the packed destination.
// Anything referenced down the chain by these files will also be brought in

// If you just specify the directory
// then webpack will look at the named directory inside node_modules -> package.json -> The main field
var entrypoints = { 'main': './ClientApp/common/boot.ts' };


// Plugins
function plugins() {
  return [
    // Set the NODE_ENV environment variable to production / development
    new webpack.DefinePlugin({ 'process.env.NODE_ENV': isDevBuild ? '"development"' : '"production"' }),
    new webpack.DllReferencePlugin({ context: __dirname, manifest: require('./wwwroot/dist/vendor-manifest.json') }),
    new VueLoaderPlugin(),
    new ForkTsCheckerWebpackPlugin()
  ].concat(isDevBuild ? [
    // Plugins that apply in development builds only
    new webpack.SourceMapDevToolPlugin({
      filename: '[file].map', // Remove this line if you prefer inline source maps
      moduleFilenameTemplate: path.relative(bundleOutputDir, '[resourcePath]') // Point sourcemap entries to the original file locations on disk
    })
  ]:[
      // Plugins that apply in production builds only
      new ExtractCssChunks({ filename: 'styles/site.css' }),
      // Condense the CSS to as small as possible, and remove comments
      new OptimizeCssAssetsPlugin({
        cssProcessorPluginOptions: {
          preset: ['default', { discardComments: { removeAll: true } }]
        }
      })
  ]);
};


// Rules
function rules() {
  return [
    // Typescript files
    { test: /\.ts$/, include: /ClientApp/, loader: 'ts-loader', options: { appendTsSuffixTo: [/\.vue$/] } },

    // Vue files
    { test: /\.vue$/, include: /ClientApp/, loader: 'vue-loader' },

    // Vanilla CSS
    { test: /\.css$/, use: isDevBuild ?
      // Development - inline css
      ['style-loader', 'css-loader?sourceMap=true'] :
      // Production - site.css
      [ExtractCssChunks.loader, 'css-loader']
    },

    // Scss (css) files
    { test: /\.(sass|scss)$/, use: isDevBuild ?
      // Development - inline css
      ['style-loader',
        { loader: 'css-loader', options: { importLoaders: 1, sourceMap: true } },
        { loader: 'sass-loader', options: { includePaths: ['ClientApp/css', 'node_modules'], implementation: require('sass'), sourceMap: true } }
      ] :
      // Production - site.css
      [ExtractCssChunks.loader,
        { loader: 'css-loader', options: { importLoaders: 1 } },
        { loader: 'sass-loader', options: { includePaths: ['ClientApp/css', 'node_modules'], implementation: require('sass') } }
      ]
    },

    // images
    { test: /\.(png|jpg|jpeg|gif|svg)$/, use:
      [{ loader: 'url-loader', options: { name: '[name].[hash].[ext]', outputPath: 'img/', limit: 25000 } }]
    },

    // Fonts
    { test: /.(ttf|otf|eot|svg|woff(2)?)$/, use:
      [{ loader: 'file-loader', options: { name: '[name].[ext]', outputPath: 'fonts/' } }]
    }
  ];
};


// Main webpack options
module.exports = (env, argv) => {
  isDevBuild = !((argv && argv.mode === 'production') || process.env.NODE_ENV === 'production');
  console.log(`Development build: ${isDevBuild}`);

  return [{
    // If to run webpack in development or production
    mode: isDevBuild ? 'development' : 'production',
    // Style of output when running webpack
    stats: { modules: false },
    // Entry points of the js to start with when packing.
    entry: entrypoints,
    // Plugins
    plugins: plugins(),
    // Define rules / loaders for loading other related files
    module: { rules: rules() },
    // The base directory for the js source
    context: __dirname,
    // This should be set to false when SourceMapDevToolPlugin is used instead
    devtool: false,
    // Allow the use of the import statement in js without the need of the below file extensions.
    resolve: {
      extensions: ['.js', '.ts', '.vue', '.json'],
      // Allow import from common as: import 'common/xxx'
      alias: { 'common': path.resolve(__dirname, 'ClientApp/common/') }
    },
    // Output destination
    output: {
      // Destination Directory
      path: path.join(__dirname, bundleOutputDir),
      // Output relative to the site root
      publicPath: '/dist/',
      filename: '[name].js'
    },
    // Terser options for shrinking js files for production
    optimization: {
      minimizer: [new TerserPlugin({ sourceMap: true })]
    }
  }];
};
