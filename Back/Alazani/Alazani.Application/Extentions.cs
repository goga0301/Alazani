using Alazani.Application.Behaviours;
using Microsoft.Extensions.DependencyInjection;

namespace Alazani.Application;

public static class Extentions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR( config =>
        {
            config.RegisterServicesFromAssembly(typeof(Extentions).Assembly);

            config.AddOpenBehavior(typeof(UnitOfWorkBehaviour<,>));
        });
        return services;
    }
}
