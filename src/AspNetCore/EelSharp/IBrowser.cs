using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EelSharp
{
    /// <summary> Interface for browsers. </summary>
    public interface IBrowser {

        /// <summary> Launches the browser. </summary>
        void Launch();

        /// <summary> Setup the browser arguments / find the browser. </summary>
        void Setup();

        /// <summary> Gets the browser options. </summary>
        /// <returns> The browser options. </returns>
        BrowserOpts GetOpts();

        /// <summary> Searches for the browser on the path. </summary>
        /// <returns> The found browser path. </returns>
        string FindBrowser();
    }
}
