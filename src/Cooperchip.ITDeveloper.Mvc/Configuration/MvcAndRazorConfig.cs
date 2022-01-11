﻿using Cooperchip.ITDeveloper.Mvc.Extentions.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cooperchip.ITDeveloper.Mvc.Configuration
{
    public static class MvcAndRazorConfig
    {
        public static IServiceCollection AddDbMvcAndRazorConfig(this IServiceCollection services)
        {

            services.AddMvc(options =>
            {
                // Todo: Resolver DI;
                options.Filters.Add(typeof(AuditoriaIloggerFilter));

            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddControllersWithViews();
            services.AddRazorPages();

            return services;
        }
    }
}
