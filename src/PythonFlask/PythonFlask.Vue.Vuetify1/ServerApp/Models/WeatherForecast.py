
class WeatherForecast(object):

    def __init__(self):
        self.DateFormatted = ''
        self.Summary = ''
        self.TemperatureC = 0

    @property
    def TemperatureF(self):
        tmp1 = (TemperatureC / 0.5556) + 32
        return tmp1
