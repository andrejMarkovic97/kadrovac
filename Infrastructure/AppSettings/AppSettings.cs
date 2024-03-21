using Microsoft.Extensions.Configuration;

namespace Infrastructure.AppSettings;

public class AppSettings(IConfiguration configuration) : IAppSettings
{
    public string AzureSqlConnectionString { get; } = configuration.GetConnectionString("AZURE_SQL_CONNECTION_STRING");
}