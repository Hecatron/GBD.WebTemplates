"""
Web site setup
"""

# TODO call webpack build scripts from pyproj



# TODO Pull in the controllers / web pages
#import ServerApp.Controllers

import eel
from os import environ

class EelServer(object):

    def __init__(self, develop):
        """Class Initializer"""
        self.Port = 8080
        self.Develop = develop

    def get_free_port(self):
        """Find a free port for the app"""
        try:
            self.Port = int(environ.get('SERVER_PORT', '5555'))
        except ValueError:
            pass
        return self.Port

    def start(self):
        """Start Eel"""
        if self.Develop:
            # TODO launch browser
            directory = 'wwwroot'
            app = None
            page = {'port': 3000}
            flags = ['--auto-open-devtools-for-tabs']
        else:
            directory = 'wwwroot'
            #app = 'chrome-app'
            app = None
            page = 'index.html'
            flags = []

        eel.init(directory, ['.tsx', '.ts', '.jsx', '.js', '.html'])


        # These will be queued until the first connection is made, but won't be repeated on a page reload
        #say_hello_py('Python1')
        eel.say_hello_js('Python2')   # Call a JavaScript function (must be after `eel.init()`)

        eel.start(page, size=(1280, 800), options={
            'mode': app,
            'port': self.Port,
            'host': 'localhost',
            'chromeFlags': flags
        })

