using Alazani.Helpers;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alazani.Infrastructure.Repository;

public static class Extentions
{
    public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AlazaniDbContext>(x =>
        {
            x.UseNpgsql(configuration.GetSection("DatabaseSettings:ConnectionString").Value,
                        b => b.MigrationsAssembly("Alazani.Infrastructure.Repository"));

        });
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IConnectionString, ConnectionString>();
        services.AddSingleton<IDbConnectionProvider, DbConnectionProvider>();

    }

    public static void MigrateDatabase(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<AlazaniDbContext>();
        context.Database.SetConnectionString(serviceProvider.GetRequiredService<IConfiguration>()
                           .GetSection("DatabaseOptions:ConnectionString").Value);
        context.Database.Migrate();
    }


}

