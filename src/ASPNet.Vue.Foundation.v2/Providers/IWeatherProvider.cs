using System.Collections.Generic;
using ASPNet.Vue.Foundation.v2.Models;


namespace ASPNet.Vue.Foundation.v2.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
