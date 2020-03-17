using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_mLopezFleming_Bethanys.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSC237_mLopezFleming_Bethanys
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Register repositories in the services collection to be able to use wherever in application
            // AddScoped registers a service with its interface into the services collection
            services.AddScoped<IPieRepository, MockPieRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();

            // AddTransient gives back a new instance everytime you ask for one
            //services.AddTransient

            // AddSingleton creates a single instance for the entire application and reuse it
            //services.AddSingleton();

            // Support for MVC
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Helps see exceptions in development, otherwise would not appear
                app.UseDeveloperExceptionPage();
            }
            
            // More middleware

            // Redirects HTTP requests to HTTPS
            app.UseHttpsRedirection();

            // Appliction will serve static files with this 
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Routing
                endpoints.MapControllerRoute(
                    name: "default",
                    // First pass the name of the controller then the name of the action aka www.xxxxxxx/controller/action
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
