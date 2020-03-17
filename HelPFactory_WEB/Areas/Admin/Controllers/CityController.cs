using HelpFactory.DataBase;
using HelpFactory_Entities;
using HelpFactory_Services.Repositories;
using HelpFactory_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelPFactory_WEB.Areas.Admin.Controllers
{
    public class CityController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new HelpFactory_Context());
        // GET: Admin/City
        public ActionResult Index()
        {
            var model = _unitOfWork.City.GetAll();
            return View(model);
            
        }

        // GET: Admin/City/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/City/Create
        [HttpPost]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.City.Insert(city);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            else
            {
                return View(city);
            }
        }

        // GET: Admin/City/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/City/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
