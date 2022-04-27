using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inicial.Controllers
{   // Todo controller precisa erdar a classe controller
    public class HomeController : Controller    // tambel tem que estar na pasta controller
    {
        // GET: Home
        public ActionResult Index()
        {

            // toda Action retorna a regra de nogocio e develve um vizualização 
            return View();
        }
    }
}