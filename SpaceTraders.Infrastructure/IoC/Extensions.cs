using Microsoft.Extensions.DependencyInjection;
using SpaceTraders.Application.Clients;
using SpaceTraders.Infrastructure.Clients;

namespace SpaceTraders.Infrastructure.IoC;
public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ISpaceTradersClient, SpaceTradersClient>();

        return services;
    }
}
