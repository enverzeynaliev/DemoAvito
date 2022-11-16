using DemoAvito.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DemoAvito.DataAccess;

public class AdvertContextConfiguration : IDbContextOptionConfigurator<AdvertContext>
{
    private const string ConnectionStringName = "AdvertDb";
    private readonly IConfiguration _configuration;
    private readonly ILoggerFactory _loggerFactory;

    public AdvertContextConfiguration(ILoggerFactory loggerFactory, IConfiguration configuration)
    {
        _loggerFactory = loggerFactory;
        _configuration = configuration;
    }

    public void Configure(DbContextOptionsBuilder<AdvertContext> options)
    {
        var connectionString = _configuration.GetConnectionString(ConnectionStringName);
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException(
                $"Не найдена строка подключения с именем'{ConnectionStringName}'");
        }

        options.UseNpgsql(connectionString)
            .UseLoggerFactory(_loggerFactory);
    }
}