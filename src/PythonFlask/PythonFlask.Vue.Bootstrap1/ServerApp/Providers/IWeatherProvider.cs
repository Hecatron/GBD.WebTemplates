using System.Collections.Generic;
using AspNetCore.Vue.Bootstrap1.Models;


namespace AspNetCore.Vue.Bootstrap1.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
