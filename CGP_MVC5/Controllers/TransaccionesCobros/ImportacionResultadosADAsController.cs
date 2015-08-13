using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesCobros
{
    public class ImportacionResultadosADAsController : Controller
    {
        // GET: ImportacionResultadosADAs
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImportacionResultadosADAs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImportacionResultadosADAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImportacionResultadosADAs/Create
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

        // GET: ImportacionResultadosADAs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ImportacionResultadosADAs/Edit/5
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

        // GET: ImportacionResultadosADAs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ImportacionResultadosADAs/Delete/5
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
