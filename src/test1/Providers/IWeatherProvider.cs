using System.Collections.Generic;
using test1.Models;

namespace test1.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
