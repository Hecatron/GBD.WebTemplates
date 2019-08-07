from ServerApp.Controllers.HomeController import HomeController
from ServerApp.Controllers.SampleDataController import SampleDataController

# TODO
#import ServerApp.Controllers.WeatherController


def register_controllers(app):
    app.register_blueprint(HomeController)
    app.register_blueprint(SampleDataController)
