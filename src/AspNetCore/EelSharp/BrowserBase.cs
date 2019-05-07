using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace EelSharp {

    /// <summary> base class for browser. </summary>
    public abstract class BrowserBase : IBrowser {

        /// <summary> Browser Options. </summary>
        public BrowserOpts Opts { get; set; } = new BrowserOpts();

        /// <summary> Gets the browser options. </summary>
        /// <returns> The browser options. </returns>
        public BrowserOpts GetOpts() {
            return Opts;
        }

        /// <summary> Setup the browser arguments / find the browser. </summary>
        public abstract void Setup();

        /// <summary> Launch the browser. </summary>
        /// <exception cref="Exception"> Thrown when an exception error condition occurs. </exception>
        public virtual void Launch() {
            var args = "";
            foreach (var item in Opts.Args) {
                args += item + " ";
            }
            var process = Process.Start(Opts.BrowserPath, args);
            if (process == null) {
                // Failed to start
                throw new Exception("Error launching process, process == null");
            }
        }

        /// <summary> Searches for the browser on the path. </summary>
        /// <returns> The found browser path. </returns>
        public virtual string FindBrowser() {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                Opts.BrowserPath = Find_browser_win();
                return Opts.BrowserPath;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                Opts.BrowserPath = Find_browser_linux();
                return Opts.BrowserPath;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                Opts.BrowserPath = Find_browser_osx();
                return Opts.BrowserPath;
            }
            else {
                return null;
            }
        }

        /// <summary> Searches for the installed browser under windows </summary>
        /// <returns> The path to the browser. </returns>
        protected abstract string Find_browser_win();

        /// <summary> Searches for the installed browser under linux </summary>
        /// <returns> The path to the browser. </returns>
        protected abstract string Find_browser_linux();

        /// <summary> Searches for the installed browser under osx </summary>
        /// <returns> The path to the browser. </returns>
        protected abstract string Find_browser_osx();


        // TODO check out / check linux compat
        public static string FindInPath(string filename) {
            var path = Environment.GetEnvironmentVariable("PATH");
            var directories = path.Split(';');

            foreach (var dir in directories) {
                var fullpath = Path.Combine(dir, filename);
                if (File.Exists(fullpath)) return fullpath;
            }

            // filename does not exist in path
            return null;
        }
    }
}
