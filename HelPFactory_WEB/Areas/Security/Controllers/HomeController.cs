using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Areas.Security.Controllers
{
    public class HomeController : Controller
    {
        // GET: Security/Home
        public ActionResult Index()
        {
            return RedirectToAction("Login","login");
        }
    }
}