import random
from datetime import datetime
from datetime import timedelta
from ServerApp import app
from ServerApp.Models.WeatherForecast import WeatherForecast

Summaries = ['Freezing', 'Bracing', 'Chilly', 'Cool', 'Mild', 'Warm', 'Balmy', 'Hot', 'Sweltering', 'Scorching']

@app.route('/api/SampleData/', methods=['GET'])
def sample_data():
    data = []
    for idx in range(1, 5):
        newitem = WeatherForecast()
        newitem.DateFormatted = datetime.now() + timedelta(days=idx)
        newitem.TemperatureC = random.randrange(-20, 55)
        newitem.Summary = Summaries[random.randrange(len(Summaries))]
        data.append(newitem)

    # TODO
    #return str(data)
    return 'Hello World'
