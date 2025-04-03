using Customer.Application.AddCustomer;
using Customer.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Application;

public static class ServiceCollectionExtension
{

    public static IServiceCollection AddCustomerApplication(this IServiceCollection services)
    {
        services.AddInfrastructure();

        services.AddScoped<IHandler, Handler>();
        return services;
    }

}
