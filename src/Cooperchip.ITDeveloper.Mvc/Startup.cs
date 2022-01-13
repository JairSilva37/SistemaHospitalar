﻿using Cooperchip.ITDeveloper.Mvc.Configuration;
using Cooperchip.ITDeveloper.Mvc.Data;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity.Services;
using Cooperchip.ITDeveloper.Mvc.Identity.Services;
using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cooperchip.ITDeveloper.Mvc
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builer = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            if (env.IsProduction())
            {
                builer.AddUserSecrets<Startup>();
            }

            Configuration = builer.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //EXTENSÃO DA CLASSE DO BANCO
            services.AddDbContextConfig(Configuration);

            //ESXTENSÃO DAS CLASSES IDENTITY
            services.AddIdentityConfig(Configuration);

            //ESXTENSÃO DAS CLASSES RAZOR Mvc
            services.AddDbMvcAndRazorConfig();

            //EXTENSÃO DAS INEJÇÕES DE DEPENDECIAS
            services.AddDependencyInjectConfig(Configuration);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext context,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            if (env.IsProduction())
            {
                app.UseKissLogMiddleware(options =>
                {
                    options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                        Configuration["KissLog.OrganizationId"],
                        Configuration["KissLog.ApplicationId"])
                    ));
                });
            }

            var authMsgSenderOpt = new AuthMessageSenderOptions
            {
                SendGridUser=Configuration["SendGridUser"],
                SendGridkey=Configuration["SendGridkey"]
            };

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();

            });
            //CRIA O USUÁRIO ADMIN COMO ADMINISTRADOR DO SISTEMA
            DefaultUsersAndRoles.Seed(context, userManager, roleManager).Wait();
        }
    }
}
