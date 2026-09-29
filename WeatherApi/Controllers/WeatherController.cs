using Microsoft.AspNetCore.Mvc;
using WeatherApi.Models;
using WeatherApi.Services;

namespace WeatherApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherController> _logger;

    public WeatherController(
        IWeatherService weatherService,
        ILogger<WeatherController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<WeatherResponse> Get()
    {
        _logger.LogInformation("Weather API request received");

        return Ok(_weatherService.GetWeather("Pune"));
    }

    [HttpGet("{city}")]
    public ActionResult<WeatherResponse> Get(string city)
    {
        if (string.IsNullOrWhiteSpace(city))
        {
            return BadRequest("City is required.");
        }

        _logger.LogInformation(
            "Weather API request received for {City}",
            city);

        return Ok(_weatherService.GetWeather(city));
    }
}