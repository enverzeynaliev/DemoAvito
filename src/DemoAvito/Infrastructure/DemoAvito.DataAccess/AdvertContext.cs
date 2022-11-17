using DemoAvito.DataAccess.EntityConfiguration.Category;
using DemoAvito.DataAccess.EntityConfiguration.Cities;
using DemoAvito.DataAccess.EntityConfiguration.DemoAvito;
using DemoAvito.DataAccess.EntityConfiguration.Pictures;
using Microsoft.EntityFrameworkCore;

namespace DemoAvito.DataAccess;

public class AdvertContext : DbContext
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="AdvertContext"/> 
    /// </summary>
    /// <param name="options"></param>
    public AdvertContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdvertConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new PhotosConfiguration());
    }
}