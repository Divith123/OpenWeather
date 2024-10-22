using LiveWeather.Models;
using LiveWeather.Components;
using LiveWeather.Services;
using Microsoft.Extensions.Options;
using LiveWeather.DatabaseController;
using LiveWeather.Singletons;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<DatabaseController>();
builder.Services.AddMudServices();

builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("WeatherApi"));
builder.Services.AddHttpClient<WeatherService>((sp, client) =>
{
    var options = sp.GetRequiredService<IOptions<WeatherApiOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl);
});
builder.Services.AddSingleton<UserStateManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map components and set default routing
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Set up routing for the welcome page
app.MapGet("/", () => Results.Redirect("/welcome"));

app.Run();
