using ElectronNET.API;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCore.Vue.Vuetify1.ElectronNet {

    /// <summary> Main Program. </summary>
    public class Program {

        /// <summary> Main entry-point for this application. </summary>
        /// <param name="args"> An array of command-line argument strings. </param>
        public static void Main(string[] args) {
            var UseElectron = true;
            CreateWebHostBuilder(args, UseElectron).Build().Run();
        }

        /// <summary> Creates web host builder. </summary>
        /// <param name="args">        An array of command-line argument strings. </param>
        /// <param name="UseElectron"> True to use electron. </param>
        /// <returns> The new web host builder. </returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args, bool UseElectron) {
            var builder = WebHost.CreateDefaultBuilder(args);
            if (UseElectron)
                builder = builder.UseElectron(args);
            return builder.UseStartup<Startup>();
        }
    }
}
