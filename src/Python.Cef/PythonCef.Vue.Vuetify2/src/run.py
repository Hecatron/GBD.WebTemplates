"""
This script runs the Flask ServerApp for python api backend
and launches cefpython for the web frontend
"""
import click
import socket
from os import environ
from ServerApp.FlaskServer import FlaskServer

# TODO call webpack build scripts on change
# TODO during prod use flask for webpack static files
# during dev use webpack-dev-server and flask to take advantage of hmr (hot module reloading)

@click.command()
@click.option('--port', default=-1, help='Port to use for the UI.')
@click.option('--host', default='localhost', help='host address for the UI.')
@click.option('--disableui/--no-disableui', default=False, help='If to disable the UI')
def main(host, port, disableui):
    flaskserv = FlaskServer(host, port)
    if port == -1:
        flaskserv.get_free_tcp_port()
    flaskserv.start()
    x1 = 3

    # todo check disableui then launch cefpython


if __name__ == '__main__':
    main()
