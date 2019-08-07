"""
Flask / python backend for api calls
"""

import socket
from flask import Flask
from os import path
from ServerApp.Controllers import register_controllers


# Main Flask server
class FlaskServer(object):

    def __init__(self, host = 'localhost', port = -1):
        """Class Initializer"""
        self.Host = host
        self.Port = port
        self.FlaskApp = None

    def start(self):
        """Start the flask server"""
        # TODO async for cefbrowser launch
        self.FlaskApp = Flask(
            __name__,
            static_url_path='/dist',
            static_folder=path.abspath('wwwroot/dist'),
            template_folder="Views")
        register_controllers(self.FlaskApp)
        self.FlaskApp.run(self.Host, self.Port)

    def get_free_tcp_port(self):
        """Get a random free tcp port in python using sockets"""
        tcp = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        tcp.bind(('', 0))
        addr, port = tcp.getsockname()
        tcp.close()
        self.Port = port
        return port
