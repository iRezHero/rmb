using Microsoft.Extensions.DependencyInjection;

public static class EntityModelBinderExtension
{
    public static IServiceCollection AddEntityModelBinder(this IServiceCollection services, Action setupAction = null)
    {
        // TODO: implement setupAction to allow configuration of the model binder if needed
        return services;
    }
}