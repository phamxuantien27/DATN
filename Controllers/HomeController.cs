using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Update.Models;
using Update.ViewModels;
using System.IO.Compression;
using Newtonsoft.Json.Linq;

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
                        on mT_PM.MaPM equals phammem.MaPM orderby mayTinh.donvi descending
                        select new DanhSachMayTinh
                        {
                            mac = mayTinh.MAC,
                            tenMT = mayTinh.TenMT,
                            ip = mayTinh.IP,
                            phienBanHienTai = mT_PM.PhienBan,
                            tenpm = phammem.TenPhanMem,
                            ngayPhatHanh=( phammem.NgayPhatHanh.ToString()),
                            phienBanMoiNhat = phammem.PhienBanMoiNhat,
                            trangThai = mT_PM.TrangThai,
                            donvi=mayTinh.donvi

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
            var query3 = from mt in context.MAYTINHs
                         where mt.DaCapNhat == false
                         group mt by mt.donvi into g orderby g.Key descending
                         select new SoLuongMayTinh
                         {
                             donvi = g.Key,
                             sl = g.Count()
                         };
            ViewBag.SL = query3.ToList();

            return View();

           
        }
        public ActionResult Phanmem()
        {
            var listPM = context.PHANMEMs.Where(x => x.MaPM != null).ToList();
            ViewBag.DS = listPM;

            return View();
        }
        [HttpPost]
        public ActionResult GetImageFromLogId(string tendonvi)
        {
            var query = from mt in context.MAYTINHs
                        where mt.DaCapNhat == false && mt.donvi ==tendonvi
                        select new DanhSachMayTinh
                        {
                            mac = mt.MAC,
                            tenMT = mt.TenMT,
                            ip = mt.IP,                                            
                            donvi = mt.donvi
                        };
            ViewBag.DS2 = query.ToList();
            return PartialView("~/Views/Home/GetImageFromLogId.cshtml");
        }

        public ActionResult BanCapNhat()
        {
            string thang = "0"+DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            string path = "https://api.msrc.microsoft.com/sug/v2.0/en-US/affectedProduct?%24orderBy=releaseDate+desc&%24filter=productFamilyId+in+%28%27100000007%27%29+and+%28releaseDate+gt+2022-06-14T00%3A00%3A00%2B07%3A00%29+and+%28releaseDate+lt+2022-"+thang+"T23%3A59%3A59%2B07%3A00%29";
            Root banCapNhat = GetUpdate(path);
            
            ViewBag.BanCapNhat =banCapNhat.value.ToList();
            return View();
        }
        
       
        public Root GetUpdate(string path)
        {
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<Root>(webClient.DownloadString(path));
            }    

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