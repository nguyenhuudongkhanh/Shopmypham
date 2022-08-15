using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebBanHangOnline
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var builder = (args); 
            //var services = builder.Services;
            //var configuration = builder.Configuration;

            //services.AddAuthentication().AddFacebook(facebookOptions =>
            //{
            //    facebookOptions.AppId = configuration["Authentication:Facebook:AppId"];
            //    facebookOptions.AppSecret = configuration["Authentication:Facebook:AppSecret"];
            //});
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}

