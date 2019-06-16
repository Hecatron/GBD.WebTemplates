import click
import subprocess
import os
from os.path import abspath, dirname, join

# Modify the path for node_modules
local_env = os.environ.copy()
local_env["PATH"] = "./node_modules/.bin" + os.pathsep + local_env["PATH"]

# Run webpack
def run_webpack(webpack_file, prod, opts=[]):
    prod_str = 'development'
    if (prod):
        prod_str = 'production'
    cmdtxt = ['cross-env', 'NODE_ENV=' + prod_str, 'webpack']
    cmdtxt.extend(['--config', webpack_file])
    cmdtxt.extend(['--progress'])
    if (prod):
        cmdtxt.extend(['--hide-modules'])
    cmdtxt.extend(opts)
    click.echo('Calling: ' + ' '.join(cmdtxt))
    subprocess.run(cmdtxt, shell=True, env=local_env)

# Command Group
@click.group()
def cli_webpack():
    pass

# Build both site / vendor webpack
@cli_webpack.command(name='build', help='Rebuild both the site and vendor webpack')
@click.option('--prod', is_flag=True, help='If to build for production')
def build_cmd(prod):
    run_webpack('webpack.config.vendor.js', prod)
    run_webpack('webpack.config.js', prod)

# Build vendor webpack
@cli_webpack.command(name='build:vendor', help='Rebuild the vendor webpack file')
@click.option('--prod', is_flag=True, help='If to build for production')
def build_vendor_cmd(prod):
    run_webpack('webpack.config.vendor.js', prod)

# Build site webpack
@cli_webpack.command(name='build:site', help='Rebuild the site webpack file')
@click.option('--prod', is_flag=True, help='If to build for production')
def build_site_cmd(prod):
    run_webpack('webpack.config.js', prod)
