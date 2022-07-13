namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HEDIEUHANH")]
    public partial class HEDIEUHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HEDIEUHANH()
        {
            PHIENBANs = new HashSet<PHIENBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaHDH { get; set; }

        [StringLength(30)]
        public string TenHDH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIENBAN> PHIENBANs { get; set; }
    }
}
