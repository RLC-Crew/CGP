﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesCobros
{
    public class CobrosImportacionResultadosController : Controller
    {
        // GET: ImportacionResultados
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImportacionResultados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImportacionResultados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImportacionResultados/Create
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

        // GET: ImportacionResultados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ImportacionResultados/Edit/5
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

        // GET: ImportacionResultados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ImportacionResultados/Delete/5
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
