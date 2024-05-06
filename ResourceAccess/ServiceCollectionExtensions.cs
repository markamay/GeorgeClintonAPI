using Microsoft.Extensions.DependencyInjection;
using ResourceAccess.Engines;
using ResourceAccess.Managers;

namespace ResourceAccess;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddResourceAccess(this IServiceCollection services)
    {
        services.AddScoped<IGeorgeClintonEngine, GeorgeClintonEngine>();
        services.AddScoped<IGeorgeClintonManager, GeorgeClintonManager>();

        return services;
    }
}
