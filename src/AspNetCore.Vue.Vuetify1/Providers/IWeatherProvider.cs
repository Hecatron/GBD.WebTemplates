using System.Collections.Generic;
using AspNetCore.Vue.Vuetify.Models;


namespace AspNetCore.Vue.Vuetify.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
