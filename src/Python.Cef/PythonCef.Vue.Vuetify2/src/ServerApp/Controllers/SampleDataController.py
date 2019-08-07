import random
from datetime import datetime
from datetime import timedelta
from ServerApp.Models.WeatherForecast import WeatherForecast
from flask import Blueprint, render_template, abort, jsonify

SampleDataController = Blueprint('SampleDataController', __name__)

Summaries = ['Freezing', 'Bracing', 'Chilly', 'Cool', 'Mild', 'Warm', 'Balmy', 'Hot', 'Sweltering', 'Scorching']


@SampleDataController.route('/api/SampleData/WeatherForecasts', methods=['GET'])
def sample_data():
    data = []
    for idx in range(1, 5):
        newitem = WeatherForecast()
        newitem.DateFormatted = (datetime.now() + timedelta(days=idx)).strftime("%d/%m/%Y")
        newitem.TemperatureC = random.randrange(-20, 55)
        newitem.Summary = Summaries[random.randrange(len(Summaries))]
        data.append(newitem)
    ret = [e.serialize() for e in data]
    return jsonify(ret)
