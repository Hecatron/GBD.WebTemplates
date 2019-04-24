"""
The flask application package.
"""

# TODO call webpack build scripts from pyproj

from flask import Flask
from os import path

app = Flask(
    __name__,
    template_folder="Views",
    static_folder=path.abspath('wwwroot/dist'),
    static_url_path='/dist')

import ServerApp.Controllers
