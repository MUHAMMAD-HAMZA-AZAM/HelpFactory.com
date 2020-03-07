using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Areas.Security.Controllers
{
    public class ResetPasswordController : Controller
    {
        // GET: Security/ResetPassword
        public ActionResult resetPassword()
        {
            return View();
        }
    }
}