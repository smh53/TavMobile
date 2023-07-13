using Application.Common.Persistence;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddPersistence();

            return services;
        }

        public static IServiceCollection AddPersistence(
      this IServiceCollection services)
        {
            services.AddDbContext<TavMobileDbContext>(options =>
                options.UseSqlServer(""));
            services.AddScoped<ISectionRepository, SectionRepository>();

            return services;
        }
    }
}