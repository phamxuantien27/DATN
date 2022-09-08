namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PM_CVE
    {
        public int id { get; set; }

        public int? MaPM { get; set; }

        [StringLength(20)]
        public string MaCVE { get; set; }

        public virtual CVE CVE { get; set; }

        public virtual PHANMEM PHANMEM { get; set; }
    }
}
