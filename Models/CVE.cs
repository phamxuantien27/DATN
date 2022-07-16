namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CVE")]
    public partial class CVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CVE()
        {
            PHIENBANs = new HashSet<PHIENBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaCVE { get; set; }

        public string MoTa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhatHien { get; set; }

        [StringLength(20)]
        public string MucDo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIENBAN> PHIENBANs { get; set; }
    }
}
