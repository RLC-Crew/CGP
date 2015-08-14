using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesPagos
{
    public class PagosConciliacionController : Controller
    {
        // GET: Conciliacion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conciliacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conciliacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conciliacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Conciliacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conciliacion/Edit/5
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

        // GET: Conciliacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conciliacion/Delete/5
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
