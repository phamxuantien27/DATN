using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Update.Models;

namespace Update.Controllers
{
    public class PhanMemController : Controller
    {
        private Model1 context = new Model1();
        // GET: PhanMem
        public ActionResult Index()
        {
            var listPM = context.MT_PM.Where(x => x.MaMT == 2).ToList();
            ViewBag.PM = listPM;
            var listPM1 = context.PHANMEMs.ToList();
            foreach(var x in listPM1)
            {
                foreach(var y in listPM)
                {
                    if (x.MaPM == y.MaPM)
                    {
                        listPM1.Remove(x);
                        break;
                    }
                }
            }
            ViewBag.PM1 = listPM1;
            return View();
        }
        public FileResult DownloadFile(string name)
        {
            string path = Server.MapPath("~/Storage/") + name;

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", name);
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
