using AspNetCore.Vue.Vuetify1.ElectronNet.Models;
using System.Collections.Generic;

namespace AspNetCore.Vue.Vuetify1.ElectronNet.Providers {

    /// <summary> Interface for weather provider. </summary>
    public interface IWeatherProvider {

        /// <summary> Gets the forecasts. </summary>
        /// <returns> The forecasts. </returns>
        List<WeatherForecast> GetForecasts();
    }
}
