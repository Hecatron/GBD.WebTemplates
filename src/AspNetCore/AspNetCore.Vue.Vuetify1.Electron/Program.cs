using Microsoft.AspNetCore;
using ElectronNET.API;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCore.Vue.Vuetify1
{
    public class Program {
        public static void Main(string[] args) {
            var UseElectron = true;
            CreateWebHostBuilder(args, UseElectron).Build().Run();
        }

        /// <summary> Creates web host builder</summary>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args, bool UseElectron) {
            var builder = WebHost.CreateDefaultBuilder(args);
            if (UseElectron)
                builder = builder.UseElectron(args);
            return builder.UseStartup<Startup>();
        }
    }
}
