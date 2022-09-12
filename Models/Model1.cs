using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Update.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<CVE> CVEs { get; set; }
        public virtual DbSet<MAYTINH> MAYTINHs { get; set; }
        public virtual DbSet<MT_PM> MT_PM { get; set; }
        public virtual DbSet<PHANMEM> PHANMEMs { get; set; }
        public virtual DbSet<PM_CVE> PM_CVE { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CVE>()
                .Property(e => e.MaCVE)
                .IsFixedLength();

            modelBuilder.Entity<CVE>()
                .Property(e => e.MucDo)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.TenMT)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.MAC)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.IP)
                .IsFixedLength();

            modelBuilder.Entity<MT_PM>()
                .Property(e => e.PhienBan)
                .IsFixedLength();

            modelBuilder.Entity<MT_PM>()
                .Property(e => e.TrangThai)
                .IsFixedLength();

            modelBuilder.Entity<PHANMEM>()
                .Property(e => e.PhienBanMoiNhat)
                .IsFixedLength();

            modelBuilder.Entity<PM_CVE>()
                .Property(e => e.MaCVE)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.role)
                .IsFixedLength();
        }
    }
}
