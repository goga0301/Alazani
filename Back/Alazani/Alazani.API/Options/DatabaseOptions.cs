using System.ComponentModel.DataAnnotations;

namespace Alazani.API.Options
{
    public class DatabaseOptions
    {
        [Required]
        public string ConnectionString { get; init; } = String.Empty;
    }
}
