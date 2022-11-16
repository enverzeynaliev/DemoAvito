namespace DemoAvito.Domain;

/// <summary>
/// Модель описания списка картинок
/// </summary>
public class Pictures
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid PictureId { get; set; }

    /// <summary>
    /// Загружаемый пользователем файл картинки
    /// </summary>
    
    public string Photo { get; set; }

    /// <summary>
    /// Связь с таблицей объявления
    /// </summary>
    public Adverts Advert { get; set; }
}