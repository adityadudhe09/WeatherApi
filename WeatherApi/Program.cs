using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using WeatherApi.Services;

var builder = WebApplication.CreateBuilder(args);

// ------------------------------------------------------------
// Logging
// ------------------------------------------------------------

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// ------------------------------------------------------------
// Configuration
// ------------------------------------------------------------

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile(
        "appsettings.json",
        optional: false,
        reloadOnChange: true)
    .AddJsonFile(
        $"appsettings.{builder.Environment.EnvironmentName}.json",
        optional: true,
        reloadOnChange: true)
    .AddEnvironmentVariables();

// ------------------------------------------------------------
// Services
// ------------------------------------------------------------

builder.Services.AddControllers();

builder.Services.AddHealthChecks();

builder.Services.AddSingleton<IWeatherService, WeatherService>();

var app = builder.Build();

// ------------------------------------------------------------
// HTTP pipeline
// ------------------------------------------------------------

app.UseHttpsRedirection();

app.MapControllers();

app.MapHealthChecks("/health");

app.Run();