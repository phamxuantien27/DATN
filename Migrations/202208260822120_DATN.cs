namespace Update.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DATN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CVE",
                c => new
                    {
                        MaCVE = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        MoTa = c.String(),
                        NgayPhatHanh = c.DateTime(storeType: "date"),
                        MucDo = c.String(maxLength: 20, fixedLength: true),
                    })
                .PrimaryKey(t => t.MaCVE);
            
            CreateTable(
                "dbo.PM_CVE",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MaPM = c.Int(),
                        MaCVE = c.String(maxLength: 20, fixedLength: true),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CVE", t => t.MaCVE)
                .ForeignKey("dbo.PHANMEM", t => t.MaPM)
                .Index(t => t.MaPM)
                .Index(t => t.MaCVE);
            
            CreateTable(
                "dbo.PHANMEM",
                c => new
                    {
                        MaPM = c.Int(nullable: false),
                        TenPhanMem = c.String(),
                        PhienBanMoiNhat = c.String(maxLength: 50, fixedLength: true),
                        NhaPhatHanh = c.String(maxLength: 50),
                        NgayPhatHanh = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.MaPM);
            
            CreateTable(
                "dbo.MT_PM",
                c => new
                    {
                        id = c.Int(nullable: false),
                        MaMT = c.Int(),
                        MaPM = c.Int(),
                        PhienBan = c.String(maxLength: 50, fixedLength: true),
                        TrangThai = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MAYTINH", t => t.MaMT)
                .ForeignKey("dbo.PHANMEM", t => t.MaPM)
                .Index(t => t.MaMT)
                .Index(t => t.MaPM);
            
            CreateTable(
                "dbo.MAYTINH",
                c => new
                    {
                        MaMT = c.Int(nullable: false),
                        TenMT = c.String(maxLength: 50, fixedLength: true),
                        MAC = c.String(maxLength: 30, fixedLength: true),
                        IP = c.String(maxLength: 15, fixedLength: true),
                        HDH = c.String(),
                        DaCapNhat = c.Boolean(),
                    })
                .PrimaryKey(t => t.MaMT);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.TAIKHOAN",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        username = c.String(maxLength: 20, fixedLength: true),
                        password = c.String(maxLength: 10, fixedLength: true),
                        role = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PM_CVE", "MaPM", "dbo.PHANMEM");
            DropForeignKey("dbo.MT_PM", "MaPM", "dbo.PHANMEM");
            DropForeignKey("dbo.MT_PM", "MaMT", "dbo.MAYTINH");
            DropForeignKey("dbo.PM_CVE", "MaCVE", "dbo.CVE");
            DropIndex("dbo.MT_PM", new[] { "MaPM" });
            DropIndex("dbo.MT_PM", new[] { "MaMT" });
            DropIndex("dbo.PM_CVE", new[] { "MaCVE" });
            DropIndex("dbo.PM_CVE", new[] { "MaPM" });
            DropTable("dbo.TAIKHOAN");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.MAYTINH");
            DropTable("dbo.MT_PM");
            DropTable("dbo.PHANMEM");
            DropTable("dbo.PM_CVE");
            DropTable("dbo.CVE");
        }
    }
}
