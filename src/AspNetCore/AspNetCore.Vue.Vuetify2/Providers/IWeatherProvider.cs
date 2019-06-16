using AspNetCore.Vue.Vuetify1.Models;
using System.Collections.Generic;

namespace AspNetCore.Vue.Vuetify1.Providers {

    /// <summary> Interface for weather provider. </summary>
    public interface IWeatherProvider {

        /// <summary> Gets the forecasts. </summary>
        /// <returns> The forecasts. </returns>
        List<WeatherForecast> GetForecasts();
    }
}
