using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EelSharp
{
    /// <summary> Browser Options. </summary>
    public class BrowserOpts {

        /// <summary> Path to the browser executable. </summary>
        public string BrowserPath { get; set; }

        // TODO is there a class for Http url's?
        /// <summary> Url to pass to the browser. </summary>
        public string url { get; set; }


        /// <summary> arguments to pass to the browser. </summary>
        public List<string> Args { get; set; } = new List<string>();
    }
}
