import random
from datetime import datetime
from datetime import timedelta
from ServerApp.Models.WeatherForecast import WeatherForecast
from ServerApp.MicroWebSrv.microWebSrv import MicroWebSrv

Summaries = ['Freezing', 'Bracing', 'Chilly', 'Cool', 'Mild', 'Warm', 'Balmy', 'Hot', 'Sweltering', 'Scorching']


@MicroWebSrv.route('/api/SampleData/WeatherForecasts')
def sample_data(httpClient, httpResponse):
    data = []
    for idx in range(1, 5):
        newitem = WeatherForecast()
        newitem.DateFormatted = (datetime.now() + timedelta(days=idx)).strftime("%d/%m/%Y")
        newitem.TemperatureC = random.randrange(-20, 55)
        newitem.Summary = Summaries[random.randrange(len(Summaries))]
        data.append(newitem)
    ret = [e.serialize() for e in data]
    httpResponse.WriteResponseJSONOk(ret)
