namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        public int id { get; set; }

        public int? MaMT { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string donvi { get; set; }

        public virtual MAYTINH MAYTINH { get; set; }
    }
}
