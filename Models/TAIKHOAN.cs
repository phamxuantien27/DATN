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
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(10)]
        public string role { get; set; }
    }
}
