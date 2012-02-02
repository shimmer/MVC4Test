using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult register()
        {
            //return Content("<div style='color:green;'>Register</div>");
            //return Json();
            return View("preRegister");
            
        }

    }
}
