from flask import Blueprint, render_template, abort

HomeController = Blueprint('HomeController', __name__)


@HomeController.route('/')
def home():
    return render_template(
        'home.html',
        title='PythonFlask.Vue.Vuetify1 Template'
    )


#using System;
#using System.Collections.Generic;
#using System.Diagnostics;
#using System.Linq;
#using System.Threading.Tasks;
#using Microsoft.AspNetCore.Mvc;

#namespace AspNetCore.Vue.Vuetify1.Controllers
#{
#    public class HomeController : Controller
#    {
#        public IActionResult Index()
#        {
#            return View();
#        }

#        public IActionResult Error()
#        {
#            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
#            return View();
#        }
#    }
#}
