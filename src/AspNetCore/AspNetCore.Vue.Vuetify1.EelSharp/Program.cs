using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System.Linq;

namespace AspNetCore.Vue.Vuetify1 {
    public class Program {
        public static void Main(string[] args) {
            var builder = CreateWebHostBuilder(args).Build();

            var buildertask = builder.RunAsync();

            var address = builder.ServerFeatures.Get<IServerAddressesFeature>().Addresses.ElementAt(1);

            // wait on this instead
            EelBootstrap(address);


            buildertask.Wait();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void EelBootstrap(string url) {
            var browser1 = new EelSharp.Browsers.Chrome(url);
            browser1.Setup();
            browser1.Launch();
        }

    }
}
