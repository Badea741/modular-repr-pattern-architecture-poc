using Customer.Infrastructure.AddCustomer;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IRepository, Repository>();
        return services;
    }
}