using Customer.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Api;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCustomerApi(this IServiceCollection services)
    {
        services.AddCustomerApplication();
        return services;
    }
}