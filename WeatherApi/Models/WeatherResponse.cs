namespace WeatherApi.Models;

public sealed class WeatherResponse
{
    public string City { get; init; } = string.Empty;

    public int TemperatureCelsius { get; init; }

    public string Condition { get; init; } = string.Empty;

    public DateTimeOffset ObservedAt { get; init; }
}