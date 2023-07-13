using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services;
using Products.Infra.Data.Repositories;

namespace Categorys.Infra.IoC
{
    public static class CategoryInjection
    {
        public static void AddCategoryInjections(this IServiceCollection service)
        {
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
