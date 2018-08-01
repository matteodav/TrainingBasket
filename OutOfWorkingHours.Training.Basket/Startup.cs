using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OutOfWorkingHours.Training.Basket.Classes;

namespace OutOfWorkingHours.Training.Basket
{
    public class Startup
    {
        private IHostingEnvironment env;


        public Startup(IHostingEnvironment env)
        {
            this.env = env;
        }

        
        public void ConfigureServices(IServiceCollection services)
        {

        }

        

        public void Configure(IApplicationBuilder app)
        {           
            app.UseStaticFiles();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(this.env.ContentRootPath, @"Configurations"))
                .AddJsonFile(string.Concat(@"ConfigurationSettings.", this.env.EnvironmentName, @".json"))
                .Build();

            var config = new Configuration();
            builder.Bind(config);
            
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });


        }
    }
}
