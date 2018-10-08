using System.Collections.Generic;
using ASPNet.Vue.BootStrap.v2.Models;


namespace ASPNet.Vue.BootStrap.v2.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
