namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIENBAN")]
    public partial class PHIENBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIENBAN()
        {
            MT_PM = new HashSet<MT_PM>();
            CVEs = new HashSet<CVE>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string MaPM { get; set; }

        [StringLength(20)]
        public string MaHDH { get; set; }

        [StringLength(15)]
        public string TenPhienBan { get; set; }

        [StringLength(10)]
        public string NgayPhatHanh { get; set; }

        public virtual HEDIEUHANH HEDIEUHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MT_PM> MT_PM { get; set; }

        public virtual PHANMEM PHANMEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CVE> CVEs { get; set; }
    }
}
