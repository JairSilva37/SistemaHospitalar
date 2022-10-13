using Cooperchip.ITDeveloper.CrossCutting.Auxiliar;
using Cooperchip.ITDeveloper.CrossCutting.Helpers;
using Cooperchip.ITDeveloper.Data.Repository;
using Cooperchip.ITDeveloper.Data.Repository.Abstractions;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using Cooperchip.ITDeveloper.Domain.Interfaces.Helpers;
using Cooperchip.ITDeveloper.Domain.Interfaces.Repository;
using Cooperchip.ITDeveloper.Domain.Interfaces.ServiceContracts;
using Cooperchip.ITDeveloper.Domain.Interfaces.Services;
using Cooperchip.ITDeveloper.Domain.Mensageria.Notifications;
using Cooperchip.ITDeveloper.Mvc.Extensions.Filters;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity.Services;
using Cooperchip.ITDeveloper.Mvc.Infra;
using KissLog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cooperchip.ITDeveloper.Mvc.Configurations
{
    public static class DependencyInjectConfig
    {
        public static IServiceCollection AddDependencyInjectConfig(this IServiceCollection services, IConfiguration configuration)
        {
            ///============INJEÇÃO DE PENENDECIAS====================//
            ///Domain=>Service
            services.AddScoped<IPacienteDomainService, PacienteDomainService>();
            ///Domain=>Repository
            services.AddScoped<IRepositoryPaciente, PacienteRepository>();

            //Salva tudo ou nada- IUnitOfWoks
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            ///Data=>Domain
            services.AddScoped<IQueryPaciente, PacienteRepository>();

            #region:Mensageria
            services.AddScoped<INotificador, Notificador>();
            #endregion

            ///=============================================================================///




            services.AddTransient<IUnitOfUpload, UnitOfUpload>();
            ///============MANTEM ESTADO DO CONTEXTO POR TODA APLICAÇÃO====================//
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ///=============================================================================//
            services.AddScoped<IUserInContext, AspNetUser>();
            services.AddScoped<IUserInAllLayer, UserInAllLayer>();

            ///============Adicionar claims para Httpcontex para a toda applicação====//
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, UserClaimsService>();

            ///=============================================================================//

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped((context) => Logger.Factory.Get());
            services.AddScoped<AuditoriaIloggerFilter>();

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(configuration);

            return services;
        }
    }
}
