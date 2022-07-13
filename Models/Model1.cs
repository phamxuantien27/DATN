using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Update.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CVE> CVEs { get; set; }
        public virtual DbSet<HEDIEUHANH> HEDIEUHANHs { get; set; }
        public virtual DbSet<MAYTINH> MAYTINHs { get; set; }
        public virtual DbSet<MT_PM> MT_PM { get; set; }
        public virtual DbSet<PHANMEM> PHANMEMs { get; set; }
        public virtual DbSet<PHIENBAN> PHIENBANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CVE>()
                .Property(e => e.MaCVE)
                .IsFixedLength();

            modelBuilder.Entity<CVE>()
                .Property(e => e.MucDo)
                .HasPrecision(3, 1);

            modelBuilder.Entity<CVE>()
                .HasMany(e => e.PHIENBANs)
                .WithMany(e => e.CVEs)
                .Map(m => m.ToTable("PB_CVE").MapLeftKey("MaCVE").MapRightKey("MaPB"));

            modelBuilder.Entity<HEDIEUHANH>()
                .Property(e => e.MaHDH)
                .IsFixedLength();

            modelBuilder.Entity<HEDIEUHANH>()
                .Property(e => e.TenHDH)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.MaMT)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.TenMT)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.MaHDH)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.MAC)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .Property(e => e.IP)
                .IsFixedLength();

            modelBuilder.Entity<MAYTINH>()
                .HasMany(e => e.MT_PM)
                .WithRequired(e => e.MAYTINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MT_PM>()
                .Property(e => e.MaMT)
                .IsFixedLength();

            modelBuilder.Entity<PHANMEM>()
                .Property(e => e.MaPM)
                .IsFixedLength();

            modelBuilder.Entity<PHANMEM>()
                .Property(e => e.PhienBanMoiNhat)
                .IsFixedLength();

            modelBuilder.Entity<PHIENBAN>()
                .Property(e => e.MaPM)
                .IsFixedLength();

            modelBuilder.Entity<PHIENBAN>()
                .Property(e => e.MaHDH)
                .IsFixedLength();

            modelBuilder.Entity<PHIENBAN>()
                .Property(e => e.TenPhienBan)
                .IsFixedLength();

            modelBuilder.Entity<PHIENBAN>()
                .Property(e => e.NgayPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<PHIENBAN>()
                .HasMany(e => e.MT_PM)
                .WithRequired(e => e.PHIENBAN)
                .HasForeignKey(e => e.MaPB)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.author)
                .IsFixedLength();
        }
    }
}
