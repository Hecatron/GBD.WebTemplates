"""
This script runs the MicroWebSrv ServerApp application using a development server.
"""

from os import environ
from ServerApp import mws

if __name__ == '__main__':
    try:
        PORT = int(environ.get('SERVER_PORT', '5555'))
    except ValueError:
        PORT = 5555
    mws._srvAddr = ('0.0.0.0', PORT)
    #mws.Start(threaded=True)

    # For debugging
    mws.Start(threaded=False)
