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
}