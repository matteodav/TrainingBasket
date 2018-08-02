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
            services.AddMvcCore();

            var builder = new ConfigurationBuilder()
               .SetBasePath(Path.Combine(this.env.ContentRootPath, @"Configurations"))
               .AddJsonFile("ConfigurationSettings.json", false)
               .AddJsonFile($"ConfigurationSettings.{this.env.EnvironmentName}.json", true)
               .Build();

            var config = new Configuration();
            builder.Bind(config);

            services.AddSingleton(typeof(Classes.IConfiguration), config);
        }

        

        public void Configure(IApplicationBuilder app)
        {
            if(!this.env.IsProduction())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
                        
           
            
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});


        }
    }
}
