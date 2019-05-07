using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EelSharp.Browsers {

    /// <summary> For chrome browsers. </summary>
    public class Chrome : BrowserBase {

        /// <summary> Default constructor. </summary>
        public Chrome() { }

        /// <summary> Constructor. </summary>
        /// <param name="loadUrl"> Location for the browser. </param>
        public Chrome(string loadUrl = "http://localhost") {
            Opts.url = loadUrl;
        }

        /// <summary> Setup the browser arguments / find the browser. </summary>
        public override void Setup() {
            FindBrowser();
            Opts.Args.Clear();
            Opts.Args.Add("--app="+ Opts.url);
        }

        /// <summary> Searches for the installed chrome under windows </summary>
        /// <returns> The path to chrome. </returns>
        protected override string Find_browser_win() {
            var regkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";
            using (var key = Registry.LocalMachine.OpenSubKey(regkey)) {
                if (key?.GetValue("") is string configuredPath)
                    return configuredPath;
            }
            using (var key = Registry.CurrentUser.OpenSubKey(regkey)) {
                if (key?.GetValue("") is string configuredPath)
                    return configuredPath;
            }
            return null;
        }

        /// <summary> Searches for the installed browser under linux. </summary>
        /// <returns> The path to chrome. </returns>
        protected override string Find_browser_linux() {
            // tODO
            return null;
        }

        /// <summary> Searches for the installed browser under osx. </summary>
        /// <returns> The path to chrome. </returns>
        protected override string Find_browser_osx() {
            // tODO
            return null;
        }
    }
}
