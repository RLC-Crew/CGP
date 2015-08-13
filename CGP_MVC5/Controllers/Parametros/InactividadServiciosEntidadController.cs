using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.Parametros
{
    public class InactividadServiciosEntidadController : Controller
    {
        // GET: InactividadServiciosEntidad
        public ActionResult Index()
        {
            return View();
        }

        // GET: InactividadServiciosEntidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InactividadServiciosEntidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InactividadServiciosEntidad/Create
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

        // GET: InactividadServiciosEntidad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InactividadServiciosEntidad/Edit/5
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

        // GET: InactividadServiciosEntidad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InactividadServiciosEntidad/Delete/5
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
