import click
import sys
sys.path.insert(0,'../../../tools')

from cli_npm import cli_npm
from cli_webpack import cli_webpack

if __name__ == '__main__':
    cli = click.CommandCollection(sources=[cli_npm, cli_webpack])
    cli()
