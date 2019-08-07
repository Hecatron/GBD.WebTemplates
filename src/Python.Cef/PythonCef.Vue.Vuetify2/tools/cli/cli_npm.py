import click
import subprocess
import os
from os.path import abspath, dirname, join

# Modify the path for node_modules
local_env = os.environ.copy()
local_env["PATH"] = "./node_modules/.bin" + os.pathsep + local_env["PATH"]

# Run npm
def run_npm(cmd, npmcmd='npm', opts=[]):
    cmdtxt = [npmcmd, cmd]
    cmdtxt.extend(opts)
    click.echo('Calling: ' + ' '.join(cmdtxt))
    subprocess.run(cmdtxt, shell=True, env=local_env)

# Command Group
@click.group()
def cli_npm():
    pass

# Install via npm / pnpm / yarn install
@cli_npm.command(name='install', help='run npm install to install node_modules')
@click.option('--npmcmd', default='pnpm', help='npm command to use: npm, yarn, pnpm (default pnpm)')
def install_cmd(npmcmd):
    if npmcmd not in ['npm', 'pnpm', 'yarn']:
        raise Exception('Valid values are npm, yarn, pnpm')
    run_npm('install', npmcmd)


# Show outdated packages
@cli_npm.command(name='outdated', help='Show outdated npm packages')
@click.option('--npmcmd', default='pnpm', help='npm command to use: npm, yarn, pnpm (default pnpm)')
def outdated_cmd(npmcmd):
    if npmcmd not in ['npm', 'pnpm', 'yarn']:
        raise Exception('Valid values are npm, yarn, pnpm')
    run_npm('outdated', npmcmd)
