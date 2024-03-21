using Infrastructure.AppSettings;

namespace WebApi.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddMyDependencyGroup(this IServiceCollection services)
    {
        services.AddScoped<IAppSettings, AppSettings>();
        
        return services;
    }
}