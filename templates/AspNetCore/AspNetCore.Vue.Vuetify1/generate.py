import sys
sys.path.insert(0, '../../')
from lib.BaseTemplate import BaseTemplate
from distutils.dir_util import copy_tree
import lib.frontends.Vuetify1 as Frontend


class SiteTemplate(BaseTemplate):
    """Site Template"""

    def __init__(self):
        super().__init__()

    def Run(self):
        """Generate the template"""
        # Create the destination directory
        self.create_dest_dir()

        # Used for multiple editors
        self.addtmplfile('lib/shared/.editorconfig')
        # Used for Visual Studio 201X
        self.addtmplfile('lib/shared/.filenesting.json')

        # Add the frontend
        self.addfile(Frontend.getpaths())

        # Todo add backend via jinja

        print("Generation Completed")

if __name__ == '__main__':
    tmpl = SiteTemplate()
    tmpl.Run()
