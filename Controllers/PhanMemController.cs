using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Update.Controllers
{
    public class PhanMemController : Controller
    {
        // GET: PhanMem
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhanMem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhanMem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhanMem/Create
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

        // GET: PhanMem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhanMem/Edit/5
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

        // GET: PhanMem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhanMem/Delete/5
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
