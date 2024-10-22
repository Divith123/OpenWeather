namespace LiveWeather.Models;

public class WeatherResponse
{
    public required Location Location { get; set; }
    public required Current Current { get; set; }
    public Forecast Forecast { get; set; } = new(); // Ensure proper initialization
}

public class Forecast
{
    public List<ForecastDay> Forecastday { get; set; } = new();
}

public class ForecastDay
{
    public string Date { get; set; } = default!;
    public Day Day { get; set; } = default!;
}

public class Day
{
    public float Maxtemp_C { get; set; }
    public float Mintemp_C { get; set; }
    public Condition Condition { get; set; } = default!;
}

public class Location
{
    public string Name { get; set; } = default!;
}

public class Current
{
    public float Temp_C { get; set; }
    public Condition Condition { get; set; } = default!;
    public float Wind_Kph { get; set; }
    public float Wind_Mph { get; set; }
    public string Wind_Dir { get; set; } = default!;
    public int Humidity { get; set; }
}

public class Condition
{
    public string Text { get; set; } = default!;
    public string Icon { get; set; } = default!;
}
