using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services;
using Products.Infra.Data.Repositories;

namespace Products.Infra.IoC
{
    public static class ProductInjection
    {
        public static void AddProductInjections(this IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
