using DemoAvito.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DemoAvito.Migrations;

public class MigrationsDbContext : AdvertContext
{
    public MigrationsDbContext(DbContextOptions options) : base(options)
    {
    }
}