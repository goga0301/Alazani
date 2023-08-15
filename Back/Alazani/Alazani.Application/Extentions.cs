using Alazani.Application.Behaviours;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Alazani.Application;

public static class Extentions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(Extentions).Assembly, includeInternalTypes: true);

        services.AddMediatR( config =>
        {
            config.RegisterServicesFromAssembly(typeof(Extentions).Assembly);

            config.AddOpenBehavior(typeof(ValidationPipelineBehaviour<,>));

            config.AddOpenBehavior(typeof(UnitOfWorkBehaviour<,>));
        });


        return services;
    }
}
