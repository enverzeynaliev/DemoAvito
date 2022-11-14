using Microsoft.AspNetCore.Http;

namespace DemoAvito.Domain;

/// <summary>
/// Модель описания списка картинок
/// </summary>
public class Pictures
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Picture { get; set; }

    /// <summary>
    /// Загружаемый пользователем файл картинки
    /// </summary>
    public string Photo { get; set; }
}