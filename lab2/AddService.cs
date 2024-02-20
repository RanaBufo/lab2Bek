using Microsoft.Extensions.DependencyInjection;

public static class MyServiceExtensions
{
    public static IServiceCollection AddMyService(this IServiceCollection services)
    {
        services.AddTransient<IValid>();
        services.AddTransient<UserDataInput>();
        return services;
    }
}