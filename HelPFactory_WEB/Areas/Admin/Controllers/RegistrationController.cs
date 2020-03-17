using HelpFactory.DataBase;
using HelpFactory_Entities;
using HelpFactory_Services;
using HelpFactory_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Areas.Admin.Controllers
{
    public class RegistrationController : Controller
    {


       // private HelpFactory_Services.Repository.IRepository<Registration_ViewModel> registration_repository;
       // private HelpFactory_Services.Repository.IRepository<Objects_ViewModel> Objects_repositoryreference = null;

       // private Objects_ViewModel Obj_repository;

       // public RegistrationController()
       // {
       //     this.registration_repository = new Repository<Registration_ViewModel>();
       //     this.Objects_repositoryreference = new Repository<Objects_ViewModel>();
       //     this.Obj_repository = new Objects_ViewModel();
       // }

       // GET: app_user// List of Data
       // public ActionResult Index()
       // {
       //     var registration_viewmodelusers = registration_repository.GetAll();
       //     return View(registration_viewmodelusers);

       // }

       // GET: app_user/Details/5
       // public ActionResult Details(int Id)
       // {

       //     var registration_viewmodel = registration_repository.GetById(Id);
       //     return View();

       // }

       // GET: app_user/Create
       //[HttpGet]
       // public ActionResult Create()
       // {
       //     return View();
       // }

       // POST: app_user/Create
       //[HttpPost]
       // public ActionResult Create(Registration_ViewModel registration_repository)
       // {

       //     try
       //     {
       //         if (ModelState.IsValid)
       //         {

       //             Obj_repository.CreateRegistration(registration_repository);

       //             return RedirectToAction("Index");

       //         }
       //         else
       //         {

       //             return RedirectToAction("Index");
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         TempData["Msg"] = "Record Added Failed" + ex.Message;
       //         return RedirectToAction("Index");

       //     }

       //     return View();
       // }

       // // GET: app_user/Edit/5
       // public ActionResult Edit(int Id)
       // {
       //     var app_user = _repository.GetById(Id);
       //     return View(app_user);
       // }

       // // POST: app_user/Edit/5
       // [HttpPost]

       // public ActionResult Edit(Registration_ViewModel registration_ViewModel)
       // {
       //     if (ModelState.IsValid)
       //     {
       //         _repository.Update(app_User);
       //         _repository.Save();
       //         return RedirectToAction("Index");
       //     }
       //     else
       //     {
       //         return View(app_User);
       //     }
       // }

       // // GET: app_user/Delete/5
       // public ActionResult Delete(int Id)
       // {
       //     var app_user = _repository.GetById(Id);
       //     return View(app_user);
       // }

       // // POST: app_user/Delete/5
       // [HttpPost]
       // public ActionResult DeleteConfirmed(int Id)
       // {
       //     var app_user = _repository.GetById(Id);
       //     _repository.Delete(Id);
       //     _repository.Save();
       //     return RedirectToAction("Index");
       // }

    }
}
