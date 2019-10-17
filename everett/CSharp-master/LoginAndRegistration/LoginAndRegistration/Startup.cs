﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LoginAndRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAndRegistration
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {   //used for building key/value based configuration like in json
            var builder = new ConfigurationBuilder()
                //sets the root path for the app to be this one
                .SetBasePath(environment.ContentRootPath).AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; private set; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
            services.AddScoped<DBConnector>();
            
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddMvc();
            services.AddSession();
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
            app.UseMvcWithDefaultRoute();
            
        }
    }
}