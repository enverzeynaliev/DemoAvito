using Microsoft.EntityFrameworkCore;

namespace DemoAvito.DataAccess.Interface
{
    /// <summary>
    /// Конфигуратор контекста
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public interface IDbContextOptionConfigurator<TContext> where TContext : DbContext
    {
        /// <summary>
        /// Выполняет конфигурацию контекста
        /// </summary>
        /// <param name="options"></param>
        void Configure(DbContextOptionsBuilder<TContext> options);
    }
}