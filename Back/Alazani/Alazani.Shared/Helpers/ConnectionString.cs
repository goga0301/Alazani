using Microsoft.Extensions.Configuration;

namespace Alazani.Shared.Helpers;

public interface IConnectionString
{
    string Alazani { get; }
}

public class ConnectionString : IConnectionString
{
    public string Alazani { get; private set; }

    public ConnectionString(IConfiguration configuration)
    {
        Alazani = configuration.GetSection("DatabaseOptions:ConnectionString").Value ?? throw new ArgumentNullException("Alazani connection string is null");
    }
}
