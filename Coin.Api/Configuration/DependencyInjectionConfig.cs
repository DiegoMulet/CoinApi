using Coin.Api.Controllers;
using Coin.Application.Interfaces;
using Coin.Application.Services;
using Coin.Data.Context;
using Coin.Data.Repository;
using Coin.Domain.Interfaces.Repositorys;
using Coin.Domain.Interfaces.Services;
using Coin.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Coin.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<CoinDbContext>();

            services.AddScoped<ICoinTypeRepository, CoinTypeRepository>();
            services.AddScoped<ICoinTypeService, CoinTypeService>();
            services.AddScoped<ICoinTypeAppService, CoinTypeAppService>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
