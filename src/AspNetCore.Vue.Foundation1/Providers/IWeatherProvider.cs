using System.Collections.Generic;
using AspNetCore.Vue.Foundation1.Models;


namespace AspNetCore.Vue.Foundation1.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
