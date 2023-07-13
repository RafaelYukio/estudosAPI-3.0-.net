using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services;
using Products.Infra.Data.Repositories;

namespace Products.Infra.IoC
{
    public static class DescriptionInjection
    {
        public static void AddDescriptionInjections(this IServiceCollection service)
        {
            service.AddScoped<IDescriptionService, DescriptionService>();
            service.AddScoped<IDescriptionRepository, DescriptionRepository>();
        }
    }
}
