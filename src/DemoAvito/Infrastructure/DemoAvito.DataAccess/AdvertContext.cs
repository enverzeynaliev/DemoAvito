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
}