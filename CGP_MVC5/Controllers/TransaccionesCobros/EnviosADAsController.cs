﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers.TransaccionesCobros
{
    public class EnviosADAsController : Controller
    {
        // GET: EnviosADAs
        public ActionResult Index()
        {
            return View();
        }

        // GET: EnviosADAs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnviosADAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnviosADAs/Create
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

        // GET: EnviosADAs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnviosADAs/Edit/5
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

        // GET: EnviosADAs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnviosADAs/Delete/5
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
