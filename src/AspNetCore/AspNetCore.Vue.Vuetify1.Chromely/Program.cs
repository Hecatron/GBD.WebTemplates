using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AspNetCore.Vue.Vuetify1.Chromely {
    public class Program {
        public static void Main(string[] args) {

            // Get the config settings
            var config = GetSettings();

            // Setup the webhost backend
            var builder = CreateWebHostBuilder(config, args).Build();

            // Run the webhost backend
            builder.Run();
        }


        private static IConfigurationRoot GetSettings() {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .Build();

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


        private static IWebHostBuilder CreateWebHostBuilder(IConfigurationRoot config, string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(config)
                .UseStartup<Startup>();


        private static int FreeTcpPort() {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }

    }
}
