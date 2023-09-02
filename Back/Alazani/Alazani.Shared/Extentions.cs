using Alazani.Shared.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Alazani.Shared;

public static class Extentions
{
    public static void AddHelperServices(IServiceCollection services)
    {
        services.AddSingleton<IConnectionString, ConnectionString>();
    }
}
