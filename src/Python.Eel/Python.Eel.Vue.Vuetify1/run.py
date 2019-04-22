"""
Main launch python script for eel
"""

import eel
import sys
from ServerApp import EelServer


@eel.expose                         # Expose this function to Javascript
def say_hello_py(x):
    print('Hello from %s' % x)

if __name__ == '__main__':

    # Pass any second argument to enable debugging. Production distribution can't receive arguments
    developmode = len(sys.argv) == 2
    server = EelServer(developmode)
    server.get_free_port()
    server.start()

    #mws._srvAddr = ('0.0.0.0', PORT)

