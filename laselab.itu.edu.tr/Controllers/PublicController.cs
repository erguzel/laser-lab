using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laselab.itu.edu.tr.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        public ActionResult Welcome()
        {
            return View();
        }

        // GET: Public/Details/5
        public ActionResult AboutUs(int id)
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }
        public ActionResult Facility()
        {
            return View();
        }
        public ActionResult Publications()
        {
            return View();
        }
        public ActionResult Members()
        {
            return View();
        }
        public ActionResult Collaborations()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return Redirect("/Home/Index");
        }
        // POST: Public/Create
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

        // GET: Public/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Public/Edit/5
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

        // GET: Public/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Public/Delete/5
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
