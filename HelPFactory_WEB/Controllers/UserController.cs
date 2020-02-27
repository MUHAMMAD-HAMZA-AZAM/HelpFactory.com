using HelpFactory_Entities;
using HelpFactory_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Controllers
{
    public class UserController : Controller
    {
        USERS_Services userService = new USERS_Services();

        [HttpGet]
        public ActionResult Index()
        {
            var users = userService.GetUsers();
            return View(User);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            userService.SaveUser(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var user = userService.GetUser(ID);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            userService.UpdateUser(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var user = userService.GetUser(ID);
            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
             userService.DeleteUser(user);
            return RedirectToAction("Index");
        }


    }
}