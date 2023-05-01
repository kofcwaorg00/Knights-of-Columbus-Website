﻿using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//for when we put in data
//using Knights_of_Columbus_Website.Data;
//using Knights_of_Columbus_Website.Services;
using Microsoft.EntityFrameworkCore;
using Knights_of_Columbus_Website.Data;
using System.Configuration;
using Knights_of_Columbus_Website.Models;

namespace Knights_of_Columbus_Website
{
    public class startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //when we add database
            services.AddDbContext<KOCDbContext>(ops => ops.UseSqlServer("name=ConnectionStrings:KOCConnectionString"));

            //services.AddSingleton<IEventData, EventData>();
            services.AddMvc(x => x.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //middleware pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");

            });

            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<KOCDbContext>();
            context.Database.EnsureCreated();
            //SeedData.SeedDatabase(context);

            app.UseStaticFiles();
            app.UseRouting();
            app.UseDeveloperExceptionPage();

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Your request was unsucessful");
            });
        }


    }
}

