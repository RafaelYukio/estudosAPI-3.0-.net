using Microsoft.Extensions.DependencyInjection;
using Products.Identity.Application.Interfaces;
using Products.Identity.Application.Services;

namespace Products.Infra.IoC
{
    public static class IdentityServices
    {
        public static void AddIdentityServices(this IServiceCollection service)
        {
            service.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
