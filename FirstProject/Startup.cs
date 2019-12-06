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
        //Added the configuration in project
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
                DeveloperExceptionPageOptions devExPage = new DeveloperExceptionPageOptions
                {
                SourceCodeLineCount = 10
                };
                app.UseDeveloperExceptionPage(devExPage);
            }

            var hostingEnvName = env.EnvironmentName;

            app.Use(async (context,next) =>
            {
                Console.WriteLine("MW1 : Incoming request");
                await next();
                Console.WriteLine("MW1 : Outgoing request");
            });

            FileServerOptions fso = new FileServerOptions();
            fso.DefaultFilesOptions.DefaultFileNames.Clear();
            fso.DefaultFilesOptions.DefaultFileNames.Add("foo.html");

            //this middleware will serve the foo.html page but when we browse another URL then exception is thrown
            //app.UseFileServer(fso);

            app.Run(async (context) =>
            {
                 Console.WriteLine("MW2 : Incoming request");

                //throw new Exception("Some raised exception");

                string myConfig = Configuration["MyKey"];
                string output = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                await context.Response.WriteAsync($"Hello World MW3 ! {output} Configs : {myConfig} Hosting Env {hostingEnvName}");

                Console.WriteLine("MW2 : Request Processed");
            });
        }
    }
}
