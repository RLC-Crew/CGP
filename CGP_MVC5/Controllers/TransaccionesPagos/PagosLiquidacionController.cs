using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesPagos
{
    public class PagosLiquidacionController : Controller
    {
        // GET: Liquidacion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Liquidacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Liquidacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Liquidacion/Create
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

        // GET: Liquidacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Liquidacion/Edit/5
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

        // GET: Liquidacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Liquidacion/Delete/5
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
