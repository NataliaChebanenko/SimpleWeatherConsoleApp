using Microsoft.Extensions.DependencyInjection;
using Refit;
using SimpleWeatherConsole.Models;
using SimpleWeatherConsole.Services;

namespace SimpleWeatherConsole;
class Program
{
    static async Task Main(string[] args)
    {
        // Register services
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton(conf => RestService.For<IWeatherApi>("https://weatherbit-v1-mashape.p.rapidapi.com"));
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var weatherApi = serviceProvider.GetService<IWeatherApi>();


        var running = true;

        while (running)
        {
            string? longitude, latitude;

            GetUserInput(out longitude, out latitude);

            WeatherDTO weather = await GetWeatherByLatLongAsync(weatherApi, longitude, latitude);

            DisplayWeather(weather);

            Console.WriteLine("Press y to check another city or n to exit the program.");
            var response = Console.ReadLine();

            if (response.ToLower() == "n")
            {
                running = false;
            }

        }
    }

    private static void DisplayWeather(WeatherDTO weather)
    {
        for (int i = 0; i <= weather.Data.Length - 1; i++)
        {
            Console.WriteLine($"Weather data for city {weather.Data[i].CityName}");
            Console.WriteLine($"Temperature: {weather.Data[i].Temp}");
            Console.WriteLine($"Sunset: {weather.Data[i].Sunset}");
            Console.WriteLine($"Snow: {weather.Data[i].Snow}");
            Console.WriteLine($"Latitude: {weather.Data[i].Lat}");
            Console.WriteLine($"Longitude: {weather.Data[i].Lon}");
            Console.WriteLine($"Clouds: {weather.Data[i].Clouds}");
        }
    }

    private static async Task<WeatherDTO> GetWeatherByLatLongAsync(IWeatherApi? weatherApi, string? longitude, string? latitude)
    {
        var weather = new WeatherDTO();

        try
        {
            weather = await weatherApi.GetWeatherByCity((float)Convert.ToDouble(latitude), (float)Convert.ToDouble(longitude));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured when fetching data from the API: {ex.Message}");
        }

        return weather;
    }

    private static void GetUserInput(out string? longitude, out string? latitude)
    {
        Console.WriteLine("Weather Console Application");

        Console.WriteLine("Enter longitude:");
        longitude = Console.ReadLine();
        Console.WriteLine("Enter latitude:");
        latitude = Console.ReadLine();

        if (string.IsNullOrEmpty(longitude) || string.IsNullOrEmpty(latitude))
        {
            throw new Exception("User did not enter latitude or longitude");
        }
    }
}

