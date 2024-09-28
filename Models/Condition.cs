
namespace BlazorWeatherApp.Models;
public class Condition
{
    public required string Text { get; set; }
    public required string Icon { get; set; }
    public int Code { get; set; }
}