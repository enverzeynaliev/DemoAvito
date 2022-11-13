using DemoAvito.Domain;

namespace DemoAvito.Contracts;
/// <summary>
/// Модель представления конкретного объявления
/// </summary>
public class DemoAvitoDto
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
    /// Описание товара(аналог кастомных полей)
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Фото объявления(вообще их будет несколько)
    /// </summary>
    public IEnumerable<Pictures> Picture { get; set; } // тут все картинки
    /// <summary>
    /// Категория объявления
    /// </summary>
    public IEnumerable<Categories> Category { get; set; } 

    /// <summary>
    /// Подкатегория объявления, в соответствии категории
    /// </summary>
    public string? SubCategory { get; set; } // аналогично категории
    
    /// <summary>
    /// Номер телефона продавца
    /// </summary>
    public string PhoneNumber { get; set; } // хранится в формате строки для записи вида +7(978)-123-23-23

    /// <summary>
    /// Местоположение, для сортировки по городам и тд 
    /// </summary>
    public IEnumerable<Cities>  LocationCity { get; set; }

    /// <summary>
    /// Id'шник создателя объявления
    /// </summary>
    public int UserId{ get; set; }
    /// <summary>
    /// Цена от продавца
    /// </summary>
    public int ProductPrice { get; set; } // спросить про NULLable поля
}