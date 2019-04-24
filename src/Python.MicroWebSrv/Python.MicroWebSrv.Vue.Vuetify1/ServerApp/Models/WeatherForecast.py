
class WeatherForecast(object):

    def __init__(self):
        self.DateFormatted = ''
        self.Summary = ''
        self.TemperatureC = 0

    @property
    def TemperatureF(self):
        tmp1 = round((self.TemperatureC / 0.5556) + 32)
        return tmp1

    def serialize(self):
        """Convert to a dictionary for use with jsonify"""
        return {
            'dateFormatted': self.DateFormatted, 
            'temperatureC': self.TemperatureC,
            'summary': self.Summary,
            'temperatureF': self.TemperatureF
        }
