namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MT_PM
    {
        public int id { get; set; }

        public int MaMT { get; set; }

        public int MaPM { get; set; }

        [StringLength(50)]
        public string PhienBan { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual MAYTINH MAYTINH { get; set; }

        public virtual PHANMEM PHANMEM { get; set; }
    }
}
