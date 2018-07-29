using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ASPNetCore
{
    public class StartUp
    {
        //private IConfigurationRoot _config;
        private IConfiguration _config { get; }

        // public StartUp(IHostingEnvironment hosting)
        // {
        //     var builder = new ConfigurationBuilder()
        //         .SetBasePath(hosting.ContentRootPath)
        //         .AddJsonFile("appsettings.json");

        //     builder.AddEnvironmentVariables();

        //     _config = builder.Build();
        // }

        public StartUp(IConfiguration config)
        {
            _config = config;
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<MyMiddleware>();
            app.UseStaticFiles();

            string appName = _config.GetValue<string>("AppName");
            app.Run(context => context.Response.WriteAsync($"Hello World | Nome Aplicacao: {appName} | "));
        }
    }
}