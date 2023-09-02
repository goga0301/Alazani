using Alazani.Application.Behaviours;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Alazani.Application;

public static class Extentions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddMediatR( config =>
        {
            config.RegisterServicesFromAssembly(typeof(Extentions).Assembly);

            config.AddOpenBehavior(typeof(ValidationPipelineBehaviour<,>));

            config.AddOpenBehavior(typeof(UnitOfWorkBehaviour<,>));
        });

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly(), includeInternalTypes: true);
        services.AddTransient<CreateOrganizationHandler>();


        return services;
    }
}
