namespace BlazorWeatherApp.Services;

using Microsoft.Extensions.Options;
using BlazorWeatherApp.Models;
public class WeatherService
{
    private readonly HttpClient _httpClient;
 private readonly WeatherApiOptions _options;
    public WeatherService(HttpClient httpClient,IOptions<WeatherApiOptions> options){
        _httpClient = httpClient;
        _options = options.Value;

    }
    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
      
        var weather = await _httpClient.GetFromJsonAsync<WeatherResponse>($"?key={_options.ApiKey}&q={city}");
        return weather;
    }
}