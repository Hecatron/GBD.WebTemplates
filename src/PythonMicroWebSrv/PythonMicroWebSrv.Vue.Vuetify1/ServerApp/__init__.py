"""
Web site setup
"""

# TODO call webpack build scripts from pyproj

# Setup MicroWebSrv
import ServerApp.MicroWebSrv
from ServerApp.MicroWebSrv.microWebSrv import MicroWebSrv
from os import path

# Pull in the controllers / web pages
import ServerApp.Controllers

# Setup the web server
mws = MicroWebSrv(webPath = path.abspath('wwwroot'))
