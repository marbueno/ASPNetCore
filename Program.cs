using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ASPNetCore
{
    class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            // var webHost = new WebHostBuilder()
            // .UseKestrel()
            // .UseStartup<StartUp>()
            // .UseContentRoot(Directory.GetCurrentDirectory())
            // .Build();

            // webHost.Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return 
                WebHost.CreateDefaultBuilder(args)
                .UseStartup<StartUp>()
                .Build();
        }
    }
}
