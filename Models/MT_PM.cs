namespace Update.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MT_PM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPB { get; set; }

        public bool? LaHDH { get; set; }

        public virtual MAYTINH MAYTINH { get; set; }

        public virtual PHIENBAN PHIENBAN { get; set; }
    }
}
