"""
Web site setup
"""

# TODO call webpack build scripts from pyproj

from ServerApp.MicroWebSrv.microWebSrv import MicroWebSrv
from os import path
from jinja2 import Environment, PackageLoader, select_autoescape

# Create a template loader for jinja2 based templates within the View directory
jinjaenv = Environment(
    loader=PackageLoader('ServerApp', 'Views'),
    autoescape=select_autoescape(['html', 'xml'])
)

# Add Font mime types
MicroWebSrv._mimeTypes['.eot'] = 'application/vnd.ms-fontobject'
MicroWebSrv._mimeTypes['.otf'] = 'application/font-sfnt'
MicroWebSrv._mimeTypes['.ttf'] = 'application/font-sfnt'
MicroWebSrv._mimeTypes['.woff'] = 'application/font-woff'
MicroWebSrv._mimeTypes['.woff2'] = 'font/woff2'

# Pull in the controllers / web pages
import ServerApp.Controllers

# Setup the web server
mws = MicroWebSrv(webPath = path.abspath('wwwroot'))
