using Microsoft.AspNetCore.Mvc;

namespace DemoAvito.Api.Controllers;

/// <summary>
/// Работа со списком объявлений
/// </summary>
[ApiController]
[Route("v1/[controller]")]
public class OrderController : ControllerBase
{
    public OrderController()
    {
    }

    /// <summary>
    /// Вывод всех оъявлений
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Удаление конкретного объявления
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }
}