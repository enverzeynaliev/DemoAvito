using DemoAvito.AppServices.Advert.Repositories;
using DemoAvito.AppServices.Advert.Services;
using DemoAvito.DataAccess;
using DemoAvito.DataAccess.EntityConfiguration.DemoAvito;
using DemoAvito.DataAccess.Interface;
using DemoAvito.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAvito.Registrar;

public static class DemoAvitoRegistrar
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddDbContext<AdvertContext>((Action<IServiceProvider, DbContextOptionsBuilder>)
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionConfigurator<AdvertContext>>()
                .Configure((DbContextOptionsBuilder<AdvertContext>)dbOptions)));
        services.AddSingleton<IDbContextOptionConfigurator<AdvertContext>, AdvertContextConfiguration>();
        services.AddScoped(sp=>(DbContext) sp.GetRequiredService<AdvertContext>());
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        services.AddTransient<IAdvertRepository, AdvertRepository>();
        services.AddTransient<IAdvertService, AdvertService>();
        return services;
    }
}