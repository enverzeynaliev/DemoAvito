using DemoAvito.Domain;

namespace DemoAvito.Contracts;

/// <summary>
/// Модель фильтра объявлений
/// </summary>
public class AdvertFilterRequest
{
    /// <summary>
    /// Фильтр по Айдишнику
    /// </summary>
    public Guid? ProductID { get; set; }
    /// <summary>
    /// Фильтр по наименованию
    /// </summary>
    public string? Name { get; set; } 
    /// <summary>
    /// Фильтр по Цене
    /// </summary>
    public int? ProductPrice{ get; set; }
    /// <summary>
    /// Фильтр по Категории
    /// </summary>
    public Categories? Category { get; set; }
    /// <summary>
    /// По дислокации/Городу
    /// </summary>
    public Cities? LocationCity{ get; set; }
}