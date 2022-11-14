using DemoAvito.Domain;
using Microsoft.AspNetCore.Http;

namespace DemoAvito.Contracts;

public class CreateUpdateAdvertDto
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
    public IEnumerable<IFormFile> Picture { get; set; } // тут все картинки
    /// <summary>
    /// Категория объявления
    /// </summary>
    public Categories Category { get; set; } 

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
    public Cities  LocationCity { get; set; }

    /// <summary>
    /// Id'шник создателя объявления
    /// </summary>
    public int UserId{ get; set; }
    
    /// <summary>
    /// Цена от продавца
    /// </summary>
    public int ProductPrice { get; set; } // спросить про NULLable поля
}