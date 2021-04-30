using Coin.Api.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Coin.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //services.AddScoped<SimonsContext>();

            //services.AddScoped<IEstacaoRepository, EstacaoRepository>();
            //services.AddScoped<IEstacaoService, EstacaoService>();
            //services.AddScoped<IEstacaoAppService, EstacaoAppService>();

            //services.AddScoped<IMedicaoRepository, MedicaoRepository>();
            //services.AddScoped<IMedicaoService, MedicaoService>();
            //services.AddScoped<IMedicaoAppService, MedicaoAppService>();

            //services.AddScoped<IMnemonicoRepository, MnemonicoRepository>();
            //services.AddScoped<IMnemonicoService, MnemonicoService>();
            //services.AddScoped<IMnemonicoAppService, MnemonicoAppService>();   

            //services.AddScoped<IMnemonicoAppService, MnemonicoAppService>();


            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
