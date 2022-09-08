using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Update.Models;
using Update.ViewModels;

namespace Update.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private Model1 context = new Model1();
        // GET: Home
        public ActionResult Index()
        {
            IndexViewModel danhSachMayTinh = new IndexViewModel();
            var query = from mayTinh in context.MAYTINHs
                        join mT_PM in context.MT_PM on mayTinh.MaMT
                        equals mT_PM.MaMT
                        join phammem in context.PHANMEMs
                        on mT_PM.MaPM equals phammem.MaPM
                        select new DanhSachMayTinh
                        {
                            mac = mayTinh.MAC,
                            tenMT = mayTinh.TenMT,
                            ip = mayTinh.IP,
                            phienBanHienTai = mT_PM.PhienBan,
                            tenpm = phammem.TenPhanMem,
                            ngayPhatHanh = (phammem.NgayPhatHanh.ToString()),
                            phienBanMoiNhat = phammem.PhienBanMoiNhat,
                            trangThai = mT_PM.TrangThai

                        };

            ViewBag.DS = query.ToList();
            var query2 = from cve in context.CVEs
                         join pm_cve in context.PM_CVE on cve.MaCVE equals pm_cve.MaCVE
                         join phanmem in context.PHANMEMs on pm_cve.MaPM equals phanmem.MaPM
                         orderby cve.MaCVE descending
                         select new CVE_NEW
                         {
                             maCVE = cve.MaCVE,
                             tenPhanMem = phanmem.TenPhanMem
                         };
            ViewBag.CVE = query2.Take(6).ToList();

            return View();
        }
        [HttpGet]
        public ActionResult _PartialView(string donvi)
        {
            var list = context.MAYTINHs.Where(x => x.donvi != null).ToList();
            return PartialView("_DSMayTinh", list);
        }
        public ActionResult Phanmem()
        {
            var listPM = context.PHANMEMs.ToList();
            ViewBag.DS = listPM;

            return View();
        }
        public ActionResult Luutru()
        {
            var listPM = context.PHANMEMs.ToList();
            ViewBag.PM = listPM;
            return View();
        }
        [HttpPost]
        public JsonResult UploadFile(int MaPM, string Filename)
        {
            try
            {
                var pm = context.PHANMEMs.Where(x => x.MaPM == MaPM).FirstOrDefault();
                pm.Download = Filename;
                context.SaveChanges();
                return Json("Success");
            }
            catch
            {
                return Json("Failure");
            }
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string username, string pwd)
        {
            return RedirectToAction("Index");
        }
    }
}