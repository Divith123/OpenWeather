namespace LiveWeather.Services;

using Microsoft.Extensions.Options;
using LiveWeather.Models;
using System.Net.Http.Json;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly WeatherApiOptions _options;

    public WeatherService(HttpClient httpClient, IOptions<WeatherApiOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<WeatherResponse> Get5DayForecastAsync(string city)
    {
        var forecast = await _httpClient.GetFromJsonAsync<WeatherResponse>(
            $"{_options.BaseUrl}/forecast.json?key={_options.ApiKey}&q={city}&days=5");
        return forecast!;
    }
}
