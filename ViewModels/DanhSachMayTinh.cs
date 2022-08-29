using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Update.Models;

namespace Update.ViewModels
{
    public class DanhSachMayTinh
    {
        public int maMT { get; set; }
        public string tenMT { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public string phienBanHienTai { get; set; }
        public string ngayPhatHanh { get; set; }
        public string trangThai { get; set; }
        public string  tenpm { get; set; }
        public string phienBanMoiNhat { get; set; }
    }
}