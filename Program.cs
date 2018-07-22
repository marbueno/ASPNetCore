using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ASPNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var webHost = new WebHostBuilder()
            .UseKestrel()
            .Configure(
                app => {
                    app.Run(context => context.Response.WriteAsync("Hello World!"));
                }).Build();

            webHost.Run();
        }
    }
}
