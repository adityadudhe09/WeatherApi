using WeatherApi.Models;

namespace WeatherApi.Services;

public sealed class WeatherService : IWeatherService
{
    private readonly ILogger<WeatherService> _logger;
    private readonly IConfiguration _configuration;

    public WeatherService(
        ILogger<WeatherService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public WeatherResponse GetWeather(string city)
    {
        _logger.LogInformation(
            "Generating weather information for city {City}",
            city);

        var defaultTemperature =
            _configuration.GetValue<int>("Weather:DefaultTemperatureCelsius");

        var defaultCondition =
            _configuration.GetValue<string>("Weather:DefaultCondition")
            ?? "Unknown";

        return new WeatherResponse
        {
            City = city,
            TemperatureCelsius = defaultTemperature,
            Condition = defaultCondition,
            ObservedAt = DateTimeOffset.UtcNow
        };
    }
}