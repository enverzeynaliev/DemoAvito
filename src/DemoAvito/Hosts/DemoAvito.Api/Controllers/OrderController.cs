using System.Net;
using DemoAvito.Contracts;
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
    /// Вывод  объявления
    /// </summary>
    /// <returns></returns>
    [HttpGet("Get")]
    [ProducesResponseType(typeof(IReadOnlyCollection<DemoAvitoDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Вывод всех объявлений
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetAll")]
    [ProducesResponseType(typeof(IReadOnlyCollection<DemoAvitoAllDto>), (int)HttpStatusCode.OK)]
   
    public async Task<IActionResult> GetAllAsync()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <returns></returns>
    [HttpPost("Post")]
    public async Task<IActionResult> PostAsync()
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Обновление существующего объявления
    /// </summary>
    /// <returns></returns>
    [HttpPut("Put")]
    public async Task<IActionResult> UpdateAsync()
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Удаление конкретного объявления
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return await Task.FromResult(Ok());
    }
}