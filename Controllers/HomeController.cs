using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Update.Models;
using Update.ViewModels;

namespace Update.Controllers
{
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
                            ngayPhatHanh=( phammem.NgayPhatHanh.ToString()),
                            phienBanMoiNhat = phammem.PhienBanMoiNhat,
                            trangThai = mT_PM.TrangThai

                        };
          
            ViewBag.DS = query.ToList();
            var query2 = from cve in context.CVEs
                         join pm_cve in context.PM_CVE on cve.MaCVE equals pm_cve.MaCVE
                         join phanmem in context.PHANMEMs  on pm_cve.MaPM equals phanmem.MaPM orderby cve.MaCVE descending
                         select new CVE_NEW
                         {
                             maCVE = cve.MaCVE,
                             tenPhanMem = phanmem.TenPhanMem
                         };
            ViewBag.CVE = query2.Take(6).ToList();

            return View();
        }
        public ActionResult Phanmem()
        {
            var listPM = context.PHANMEMs.Where(x => x.MaPM != null).ToList();
            ViewBag.DS = listPM;

            return View();
        }
        public ActionResult Luutru()
        {
            return View();
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
            return View("Index");
        }
    }
}