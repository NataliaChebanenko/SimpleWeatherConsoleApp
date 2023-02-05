using Refit;
using SimpleWeatherConsole.Models;

namespace SimpleWeatherConsole.Services
{
    [Headers(new[] { "X-RapidAPI-Key: 614d671d11msh0cd547c11af8aa6p1c4701jsncb7ddcae4a00", "X-RapidAPI-Host: weatherbit-v1-mashape.p.rapidapi.com" })]
    public interface IWeatherApi
	{
            [Get("/current")]
            Task<WeatherDTO> GetWeatherByCity(float lat, float lon);
    }
}

