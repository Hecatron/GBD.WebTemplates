from ServerApp.MicroWebSrv.microWebSrv import MicroWebSrv

from ServerApp import jinjaenv

@MicroWebSrv.route('/')
def home(httpClient, httpResponse):

    template = jinjaenv.get_template('home.html')
    content = template.render(title='PythonMicroWebSrv.Vue.Vuetify1 Template')

    httpResponse.WriteResponseOk(
       contentType = "text/html",
       contentCharset = "UTF-8",
       content = content
    )
