using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace AspNetCore.Vue.Vuetify1.Chromely {

    /// <summary> WebHost Startup Class. </summary>
    public class Startup {

        /// <summary> Constructor. </summary>
        /// <param name="configuration"> The configuration. </param>
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        /// <summary> App Configuration. </summary>
        /// <value> App Configuration. </value>
        public IConfiguration Configuration { get; }

        /// <summary> Called by the runtime. Add services to the container. </summary>
        /// <param name="services"> The services. </param>
        public void ConfigureServices(IServiceCollection services) {
            // Add framework services.
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Simple example with dependency injection for a data provider.
            services.AddSingleton<Providers.IWeatherProvider, Providers.WeatherProviderFake>();
        }

        /// <summary> Called by the runtime. Configure the HTTP request pipeline. </summary>
        /// <param name="app"> The application. </param>
        /// <param name="env"> The environment. </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                // Webpack initialization with hot-reload.
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions {
                    HotModuleReplacement = true,
                });
            }
            else {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });

            var chromelyargs = new string[] { };
            var urls = Configuration.GetValue<string>("urls");
            ChromelyBootstrap(urls, chromelyargs);
        }

        /// <summary> Bootstrap the Chromely browser. </summary>
        public static void ChromelyBootstrap(string url, string[] args) {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_CHROMELY") == "false")
                return;
            var chromelyapp = new ChromelyApp { StartUrl = url };
            chromelyapp.Setup(args);
            chromelyapp.Start(args).Start();
        }
    }
}
