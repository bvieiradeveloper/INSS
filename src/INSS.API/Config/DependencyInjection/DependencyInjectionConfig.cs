using INSS.REPOSITORY.Interface;
using INSS.REPOSITORY.Repositorios;
using INSS.SERVICE;
using INSS.SERVICE.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace INSS.API.Config.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddInjection(this IServiceCollection services) 
        {
            services.AddScoped<ICalcularInssRepository, InssRepository>();
            services.AddScoped<ICalculadorInss, InssService>();
           
            return services;
        }
    }
}
