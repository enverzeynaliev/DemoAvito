using System.Linq.Expressions;

namespace DemoAvito.Infrastructure;
/// <summary>
/// Базовый(глупый) репозиторий
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/>.
    /// </summary>
    /// <returns></returns>
    IQueryable<TEntity> GetAll();
    /// <summary>
    /// Возвращает все элементы сущности <see cref="TEntity"/>.
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    IQueryable<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> filter);
    /// <summary>
    /// Возвращает элемент <see cref="TEntity"/> по идентификатору.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TEntity> GetByIdAsync(Guid id);
    /// <summary>
    /// Добавляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task AddAsync(TEntity model);
    /// <summary>
    /// Обновляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task UpdateAsync(TEntity model);
    /// <summary>
    /// Удаляет элемент <see cref="TEntity"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task DeleteAsync(TEntity model);
}