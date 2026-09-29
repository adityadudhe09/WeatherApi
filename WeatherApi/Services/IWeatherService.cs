using WeatherApi.Models;

namespace WeatherApi.Services;

public interface IWeatherService
{
    WeatherResponse GetWeather(string city);
}