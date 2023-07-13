using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces.Repositories;
using Products.Application.Interfaces.Services;
using Products.Application.Services;
using Products.Infra.Data.Repositories;

namespace Products.Infra.IoC
{
    public static class TagInjection
    {
        public static void AddTagInjections(this IServiceCollection service)
        {
            service.AddScoped<ITagService, TagService>();
            service.AddScoped<ITagRepository, TagRepository>();
        }
    }
}
