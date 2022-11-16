namespace DemoAvito.Domain;
/// <summary>
/// Список категорий
/// </summary>
public class Categories
{
    /// <summary>
    /// Идентификатор категории
    /// </summary>
    public Guid CategoryId { get; set; }
    /// <summary>
    /// Название категории
    /// </summary>
    public string CategoryName { get; set; }
    /// <summary>
    /// Связь с таблицей объявления
    /// </summary>
    public IEnumerable<Adverts> Advert { get; set; }
}