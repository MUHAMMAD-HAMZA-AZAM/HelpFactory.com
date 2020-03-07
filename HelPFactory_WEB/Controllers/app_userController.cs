using HelpFactory_Entities;
using HelpFactory_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Controllers
{
    public class app_userController : Controller
    {
        // Firstly We Will Create The Reference of Our Interface..
        // Bcz In C# we Cannoy Create an Object of The Interface..
        //Xo Ye Reference Variable Interface Ka Reference Rkhy Ga, is Refrence K Through Hmra Controll Interface Ma Jae Ga
        // Wha sy wo Hmri Generic Repositari Class Ma Enter Hoo kr, DB K Sth Functions Perform Kry Ga !!

        // Refernce Variable with Constrcutor Initilization
        private HelpFactory_Services.Repository.IRepository<App_User> _repository = null;
        public app_userController()
        {
            this._repository = new Repository<App_User>();
        }

        // GET: app_user// List of Data
        public ActionResult Index()
        {
            var users = _repository.GetAll();
            return View(users);
            
        }

        // GET: app_user/Details/5
        public ActionResult Details(int Id)
        {
           
            var app_user = _repository.GetById(Id);
                return View(app_user);
            
        }

        // GET: app_user/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: app_user/Create
        [HttpPost]
        public ActionResult Create(App_User app_User)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(app_User);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(app_User);
            }
        }

        // GET: app_user/Edit/5
        public ActionResult Edit(int Id)
        {
            var app_user = _repository.GetById(Id);
            return View(app_user);
        }

        // POST: app_user/Edit/5
        [HttpPost]
        
        public ActionResult Edit(App_User app_User)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(app_User);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(app_User);
            }
        }

        // GET: app_user/Delete/5
        public ActionResult Delete(int Id)
        {
            var app_user = _repository.GetById(Id);
            return View(app_user);
        }

        // POST: app_user/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int Id)
        {
            var app_user = _repository.GetById(Id);
            _repository.Delete(Id);
            _repository.Save();
            return RedirectToAction("Index");
        }

    }
}
