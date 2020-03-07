using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Areas.Security.Controllers
{
    public class LoginController : Controller
    {
        // GET: Security/Login
        public ActionResult login()
        {
            return View();
        }
        public ActionResult logout()
        {
            return RedirectToAction("Login", "login");
        }
    }
}