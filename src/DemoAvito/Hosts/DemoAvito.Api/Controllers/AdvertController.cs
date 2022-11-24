using System.Net;
using DemoAvito.AppServices.Advert.Services;
using DemoAvito.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DemoAvito.Api.Controllers;

/// <summary>
/// Работа со списком объявлений
/// </summary>
[ApiController]
[Route("v1/[controller]")]

public class AdvertController : ControllerBase
{
    private readonly IAdvertService _advertService;

    public AdvertController(IAdvertService advertService)
    {
        _advertService = advertService;
    }
    [HttpGet("getAllAdverts")]
    [ProducesResponseType(typeof(IReadOnlyCollection<DemoAvitoAllDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAll(int take, int skip, CancellationToken cancellationToken)
    {
        var result = await _advertService.GetAll(take, skip, cancellationToken);
        return Ok(result);
    }

}