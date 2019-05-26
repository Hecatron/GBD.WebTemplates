using Chromely.CefGlue;
using Chromely.CefGlue.Winapi;
using Chromely.Core;
using Chromely.Core.Helpers;
using Chromely.Core.Host;
using Chromely.Core.Infrastructure;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Vue.Vuetify1.Chromely {

    /// <summary> A chromely application wrapper class. </summary>
    public class ChromelyApp {

        /// <summary> The starturl to point chromely towards. </summary>
        /// <value> The start URL. </value>
        public string StartUrl { get; set; } = "local://app/chromely.html";

        /// <summary> Chromely configuration. </summary>
        /// <value> Chromely configuration. </value>
        public ChromelyConfiguration Config { get; set; }

        public IChromelyWindow Window { get; set; }

        /// <summary> Setup the chromely instance. </summary>
        /// <param name="args"> The arguments to pass in. </param>
        public void Setup(string[] args) {
            HostHelpers.SetupDefaultExceptionHandlers();

            var config = ChromelyConfiguration
                    .Create()
                    .WithHostMode(WindowState.Normal)
                    .WithHostTitle("chromely")
                    .WithHostIconFile("chromely.ico")
                    .WithAppArgs(args)
                    .WithHostSize(1200, 700)
                    .WithLogFile("logs\\chromely.cef_new.log")
                    .WithStartUrl(StartUrl)
                    .WithLogSeverity(LogSeverity.Info)
                    .WithDefaultSubprocess()
                    .UseDefaultLogger("logs\\chromely_new.log")
                    .UseDefaultResourceSchemeHandler("local", string.Empty)
                    .UseDefaultHttpSchemeHandler("http", "chromely.com")

                    // The single process should only be used for debugging purpose.
                    // For production, this should not be needed when the app is published and an cefglue_winapi_netcoredemo.exe 
                    // is created.

#if DEBUG
                    // Alternate approach for multi-process, is to add a subprocess application
                    // .WithCustomSetting(CefSettingKeys.BrowserSubprocessPath, full_path_to_subprocess)
                    .WithCustomSetting(CefSettingKeys.SingleProcess, true)
#endif
                ;

            Window = ChromelyWindow.Create(config);

            // Register external url schemes
            Window.RegisterUrlScheme(new UrlScheme("https://github.com/chromelyapps/Chromely", true));

            // Register current/local assembly
            Window.RegisterServiceAssembly(Assembly.GetExecutingAssembly());

            // Scan assemblies for Controller routes 
            Window.ScanAssemblies();
        }

        /// <summary> Starts Chromely using a async Task. </summary>
        /// <param name="args"> The arguments to pass in. </param>
        /// <returns> A Task. </returns>
        public Task Start(string[] args) {
            var tsk = new Task(() => {
                Thread.Sleep(2000);
                Window.Run(args);
            });
            return tsk;
        }
    }
}
