using BuberDinner.Api.Common.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TavMobile.Api.Common.Mapping;

namespace WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, TavMobileProblemDetailsFactory>();
            services.AddMappings();
            return services;
        }
    }
}