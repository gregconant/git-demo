using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class AnnotationsController : Controller
    {
        // GET: Annotations
        public ActionResult Index()
        {
            return View(new List<string> { "Annotation 1", "Annotation 2"});
            
        }

        // GET: Annotations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Annotations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Annotations/Create
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

        // GET: Annotations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Annotations/Edit/5
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

        // GET: Annotations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Annotations/Delete/5
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
