"""
Cef Browser for standalone apps
"""

# TODO


import sys
import platform
from cefpython3 import cefpython as cef
from os import environ


class CefBrowser(object):

    def __init__(self, develop):
        """Class Initializer"""
        self.Port = 8080
        self.Develop = develop

    def start(self):
        self.check_versions()
        # To shutdown all CEF processes on error
        sys.excepthook = cef.ExceptHook
        cef.Initialize()

        cef.CreateBrowserSync(url="https://www.google.com/", window_title="Hello World!")
        cef.MessageLoop()

        cef.Shutdown()

    def print_versions(self):
        ver = cef.GetVersion()
        print("CefPython Version Information")
        print("CEF Python {ver}".format(ver=ver["version"]))
        print("Chromium {ver}".format(ver=ver["chrome_version"]))
        print("CEF {ver}".format(ver=ver["cef_version"]))
        print("Python {ver} {arch}".format(ver=platform.python_version(), arch=platform.architecture()[0]))

    def check_versions(self):
        ver = cef.GetVersion()
        assert cef.__version__ >= "57.0", "CEF Python v57.0+ required to run this"


# TODO Pull in the controllers / web pages
#import ServerApp.Controllers





    #def get_free_port(self):
    #    """Find a free port for the app"""
    #    try:
    #        self.Port = int(environ.get('SERVER_PORT', '5555'))
    #    except ValueError:
    #        pass
    #    return self.Port

    #def start(self):
    #    """Start Eel"""
    #    if self.Develop:
    #        # TODO launch browser
    #        directory = 'wwwroot'
    #        app = None
    #        page = {'port': 3000}
    #        flags = ['--auto-open-devtools-for-tabs']
    #    else:
    #        directory = 'wwwroot'
    #        #app = 'chrome-app'
    #        app = None
    #        page = 'index.html'
    #        flags = []

    #    eel.init(directory, ['.tsx', '.ts', '.jsx', '.js', '.html'])


    #    # These will be queued until the first connection is made, but won't be repeated on a page reload
    #    #say_hello_py('Python1')
    #    eel.say_hello_js('Python2')   # Call a JavaScript function (must be after `eel.init()`)

    #    eel.start(page, size=(1280, 800), options={
    #        'mode': app,
    #        'port': self.Port,
    #        'host': 'localhost',
    #        'chromeFlags': flags
    #    })




