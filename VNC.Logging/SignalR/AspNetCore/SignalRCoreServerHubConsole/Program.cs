﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace SignalRCoreServerHubConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();


        //private static IWebHostBuilder CreateWebHostBuilder(string[] args)
        //{
        //   return WebHost.CreateDefaultBuilder(args)
        //        //.UseUrls(new[] { "http://localhost:8095", "https://localhost:8096" })
        //        .UseStartup<Startup>();
        //}
    }
}
