﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesPagos
{
    public class EnviosController : Controller
    {
        // GET: Envios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Envios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Envios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Envios/Create
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

        // GET: Envios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Envios/Edit/5
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

        // GET: Envios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Envios/Delete/5
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
