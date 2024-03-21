namespace Infrastructure.AppSettings;

public interface IAppSettings
{
    string AzureSqlConnectionString { get; }
}