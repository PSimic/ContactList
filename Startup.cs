﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;

    namespace ContactList
    {
        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                  services.AddDistributedMemoryCache();

                services.AddSession(options =>
                {
                 // Set a short timeout for easy testing.
                 options.IdleTimeout = TimeSpan.FromSeconds(10);
                 options.Cookie.HttpOnly = true;
                 // Make the session cookie essential
                options.Cookie.IsEssential = true;
        }); 
                services.AddMvc();
            }
            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                app.UseStaticFiles();
                app.UseSession(); 
                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
    }