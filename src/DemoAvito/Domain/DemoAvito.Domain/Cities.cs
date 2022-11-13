namespace DemoAvito.Domain;

/// <summary>
/// Модель описания города для поля Местоположение(Location) 
/// </summary>
public class Cities
{
    /// <summary>
    /// Идентификатор города
    /// </summary>
    public Guid CityId { get; set; }
    /// <summary>
    /// Название города
    /// </summary>
    public string NameCity { get; set; }
}