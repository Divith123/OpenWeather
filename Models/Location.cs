
namespace BlazorWeatherApp.Models;
public class Location
{
    public required string Name { get; set; }
    public required string Region { get; set; }
    public required string Country { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public required string Tz_Id { get; set; }
    public long Localtime_Epoch { get; set; }
    public required string Localtime { get; set; }
}
