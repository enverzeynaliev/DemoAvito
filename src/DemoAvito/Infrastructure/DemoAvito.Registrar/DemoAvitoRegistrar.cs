using DemoAvito.DataAccess;
using DemoAvito.DataAccess.Interface;
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
        return services;
    }
}