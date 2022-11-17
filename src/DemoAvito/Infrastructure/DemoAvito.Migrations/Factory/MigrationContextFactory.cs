using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DemoAvito.Migrations.Factory
{
    public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationsDbContext>
    {
        public MigrationsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MigrationsDbContext>();

            // получаем конфигурацию из файла appsettings.json
            Microsoft.Extensions.Configuration.ConfigurationBuilder builder =
                new Microsoft.Extensions.Configuration.ConfigurationBuilder();
            builder.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            // получаем строку подключения из файла appsettings.json
            string connectionString = config.GetConnectionString("PostgresAdvertDb");
            optionsBuilder.UseNpgsql(connectionString, opts => opts
                .CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
                .MigrationsAssembly(typeof(MigrationContextFactory).Assembly.FullName)
            );


            return new MigrationsDbContext(optionsBuilder.Options);
        }
    }
}