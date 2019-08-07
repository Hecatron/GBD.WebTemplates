"""
Main launch python script for cefpython
"""

import platform
import sys

from cefpython3 import cefpython as cef
from ServerApp import CefServer


#@eel.expose                         # Expose this function to Javascript
#def say_hello_py(x):
#    print('Hello from %s' % x)

if __name__ == '__main__':

    # Pass any second argument to enable debugging. Production distribution can't receive arguments
    developmode = len(sys.argv) == 2
    server = CefServer(developmode)
    server.start()
