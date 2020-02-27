using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}