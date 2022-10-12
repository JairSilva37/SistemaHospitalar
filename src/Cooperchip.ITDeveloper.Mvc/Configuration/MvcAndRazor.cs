using Cooperchip.ITDeveloper.Mvc.Extensions.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Cooperchip.ITDeveloper.Mvc.Configurations
{
    public static class MvcAndRazorConfig
    {
        public static IServiceCollection AddMvcAndRazor(this IServiceCollection services)
        {

            services.AddMvc(options =>
            {
                // Todo: Resolver DI;
                options.Filters.Add(typeof(AuditoriaIloggerFilter));

            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();

            return services;
        }
    }
}
