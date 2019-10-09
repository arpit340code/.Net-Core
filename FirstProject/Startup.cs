using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

//For Configurations
using Microsoft.Extensions.Configuration;

namespace FirstProject
{
    public class Startup
    {
       public IConfiguration Configuration {get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context,next) =>
            {
                Console.WriteLine("MW1 : Incoming request");
                await next();
                Console.WriteLine("MW1 : Outgoing request");
            });

            app.Run(async (context) =>
            {
                 Console.WriteLine("MW2 : Incoming request");

                string myConfig = Configuration["MyKey"];
                string output = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                await context.Response.WriteAsync("Hello World MW3 !" + output + " Configs : " + myConfig);

                Console.WriteLine("MW2 : Request Processed");
            });
        }
    }
}
