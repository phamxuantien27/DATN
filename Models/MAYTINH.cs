namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAYTINH")]
    public partial class MAYTINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAYTINH()
        {
            MT_PM = new HashSet<MT_PM>();
        }

        [Key]
        public int MaMT { get; set; }

        [StringLength(50)]
        public string TenMT { get; set; }

        [StringLength(30)]
        public string MAC { get; set; }

        [StringLength(15)]
        public string IP { get; set; }

        public string HDH { get; set; }

        public bool? DaCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MT_PM> MT_PM { get; set; }
    }
}
