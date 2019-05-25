using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AspNetCore.Vue.Vuetify1.Chromely {

    /// <summary> Main Program. </summary>
    public class Program {

        /// <summary> Main entry-point for this application. </summary>
        /// <param name="args"> An array of command-line argument strings. </param>
        public static void Main(string[] args) {

            // Get the config settings
            var config = GetSettings();

            // Setup the webhost backend
            var builder = CreateWebHostBuilder(config, args).Build();

            // Run the webhost backend
            builder.Run();
        }


        /// <summary> Gets the configuration settings. </summary>
        /// <returns> The configuration settings. </returns>
        private static IConfigurationRoot GetSettings() {
            // First read the configuration settings from the appsettings.json file
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .Build();

            // If usedynamicport is true, or the urls value has not been set
            // Then set within the settings a free port we can use, this way we can pass this onto chromely as a url later on
            if (config.GetValue<string>("usedynamicport") == "true" || config.GetValue<string>("urls") == null) {
                var urldict = new Dictionary<string, string> {{"urls", "http://localhost:" + FreeTcpPort()}};
                config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true)
                    .AddInMemoryCollection(urldict)
                    .Build();
            }
            return config;
        }


        /// <summary> Creates web host builder. </summary>
        /// <param name="config"> Configuration settings</param>
        /// <param name="args"> An array of command-line argument strings. </param>
        /// <returns> The new web host builder. </returns>
        private static IWebHostBuilder CreateWebHostBuilder(IConfigurationRoot config, string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(config)
                .UseStartup<Startup>();


        /// <summary> Find the next free TCP port for dynamic allocation. </summary>
        /// <returns> Free TCP Port. </returns>
        private static int FreeTcpPort() {
            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            var port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }

    }
}
