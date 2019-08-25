﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PresidentsList.Application.Interfaces;
using PresidentsList.Applications.Services.PresidentApplication;
using PresidentsList.Domain.Interfaces.PresidentService;
using PresidentsList.Domain.Services.PresidentService;
using PresidentsList.Infrastructure.Interfaces;
using PresidentsList.Infrastructure.Resources.PresidentResources;

namespace PresidentsList_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IPresidentApplication, PresidentApplication>();
            services.AddSingleton<IPresidentService, PresidentService>();
            services.AddSingleton<IPresidentResources, PresidentResource>();
            services.AddOptions();

            // Add service and create Policy with options
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .AllowAnyHeader();
            });


            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors("CorsPolicy");
        }
    }
}
