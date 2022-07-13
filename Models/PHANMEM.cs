namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANMEM")]
    public partial class PHANMEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHANMEM()
        {
            PHIENBANs = new HashSet<PHIENBAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaPM { get; set; }

        [StringLength(50)]
        public string TenPhanMem { get; set; }

        [StringLength(50)]
        public string PhienBanMoiNhat { get; set; }

        [StringLength(50)]
        public string NhaPhatHanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhatHanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIENBAN> PHIENBANs { get; set; }
    }
}
