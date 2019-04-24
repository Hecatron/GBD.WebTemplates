from ServerApp.MicroWebSrv.microWebSrv import MicroWebSrv

@MicroWebSrv.route('/')
def home(httpClient, httpResponse):
    vars = {'title': 'PythonMicroWebSrv.Vue.Vuetify1 Template'}
    httpResponse.WriteResponsePyHTMLFile(
        filepath='ServerApp/Views/home.pyhtml',
        vars=vars
        )
