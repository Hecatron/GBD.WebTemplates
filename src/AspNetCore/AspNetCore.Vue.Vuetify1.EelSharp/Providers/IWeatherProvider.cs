using System.Collections.Generic;
using AspNetCore.Vue.Vuetify1.Models;


namespace AspNetCore.Vue.Vuetify1.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
