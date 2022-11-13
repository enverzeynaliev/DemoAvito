
using DemoAvito.Domain;

namespace DemoAvito.Contracts;
/// <summary>
/// Модель представления всех объявлений на странице(быстрый просмотр)
/// </summary>
public class DemoAvitoAllDto
{
 
    /// <summary>
    /// Идентификатор товара 
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Короткое название объявления
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Дата создания объявления(при обновлении обновляется)
    /// </summary>
    public DateOnly CreationDate { get; set; }

    /// <summary>
    /// Фото объявления(вообще их будет несколько)
    /// </summary>
    public Pictures Picture { get; set; } // тут одна картинка 
    /// <summary>
    /// Категория объявления
    /// </summary>
    public IEnumerable<Categories> Category { get; set; } // лучше бы в бд сделать Enum ибо категорий численное кол-во

    /// <summary>
    /// Местоположение, для сортировки по городам и тд 
    /// </summary>
    public IEnumerable<Cities> Location { get; set; }

    /// <summary>
    /// Цена от продавца
    /// </summary>
    public int ProductPrice { get; set; } // спросить про NULLable поля
    
}