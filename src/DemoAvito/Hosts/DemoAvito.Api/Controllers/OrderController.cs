using System.Net;
using DemoAvito.Contracts;
using DemoAvito.Domain;
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
    public async Task<IActionResult> GetAsyncAdvert()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Вывод всех объявлений
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetAll")]
    [ProducesResponseType(typeof(IReadOnlyCollection<DemoAvitoAllDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsyncAdvert()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <param name="ProductId"></param>
    /// <param name="ProductName"></param>
    /// <param name="Description"></param>
    /// <param name="Picture"></param>
    /// <param name="Category"></param>
    /// <param name="PhoneNumber"></param>
    /// <param name="LocationCity"></param>
    /// <param name="ProductPrice"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("{ProductId}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> PostAsyncAdvert(Guid ProductId, string ProductName, string Description,
        IEnumerable<string> Picture, Categories Category, string PhoneNumber, Cities LocationCity, int ProductPrice,
        CancellationToken cancellationToken)
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Обновление существующего объявления
    /// </summary>
    /// <param name="ProductId"></param>
    /// <param name="ProductName"></param>
    /// <param name="Description"></param>
    /// <param name="Picture"></param>
    /// <param name="Category"></param>
    /// <param name="PhoneNumber"></param>
    /// <param name="LocationCity"></param>
    /// <param name="ProductPrice"></param>
    /// <param name="cancellationToken"></param> 
    /// <returns></returns>
    [HttpPut("{ProductId}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> UpdateAsyncAdvert(Guid ProductId, string ProductName, string Description,
        IEnumerable<string> Picture, Categories Category, string PhoneNumber, Cities LocationCity, int ProductPrice,
        CancellationToken cancellationToken)
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Удаление конкретного объявления
    /// </summary>
    /// <param name="ProductId"></param>
    /// <param name="cancellationToken"></param> 
    /// <returns></returns>
    [HttpDelete("{ProductId}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> DeleteAsyncAdvert(Guid ProductId, CancellationToken cancellationToken)
    {
        return await Task.FromResult(Ok());
    }
}