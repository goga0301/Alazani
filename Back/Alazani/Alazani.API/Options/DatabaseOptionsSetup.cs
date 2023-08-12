using Microsoft.Extensions.Options;

namespace Alazani.API.Options
{
    public class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
    {
        private readonly IConfiguration _configuration;
        public DatabaseOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Configure(DatabaseOptions options)
        {
            _configuration.GetSection(nameof(DatabaseOptions)).Bind(options);
        }
    }
}
