using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Update.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Phanmem()
        {
            return View();
        }
        public ActionResult Maytinh()
        {
            return View();
        }
        public ActionResult CVE()
        {
            return View();
        }
    }
}