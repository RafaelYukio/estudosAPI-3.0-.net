using Microsoft.Extensions.DependencyInjection;
using Products.Identity.Application.Interfaces;
using Products.Identity.Application.Services;

namespace Products.Infra.IoC
{
    public static class IdentityInjection
    {
        public static void AddIdentityInjections(this IServiceCollection service)
        {
            service.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
