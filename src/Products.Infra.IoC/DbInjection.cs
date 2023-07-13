
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Products.Identity.Infra.Data.Context;
using Products.Infra.Data.Context;

namespace Products.Infra.IoC
{
    public static class DbInjection
    {
        public static void AddDbInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<IdentityContext>();
        }
    }
}
