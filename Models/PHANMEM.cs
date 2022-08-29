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
            MT_PM = new HashSet<MT_PM>();
            PM_CVE = new HashSet<PM_CVE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPM { get; set; }

        public string TenPhanMem { get; set; }

        [StringLength(50)]
        public string PhienBanMoiNhat { get; set; }

        [StringLength(50)]
        public string NhaPhatHanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhatHanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MT_PM> MT_PM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PM_CVE> PM_CVE { get; set; }
    }
}
