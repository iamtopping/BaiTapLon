namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_KhachHangHoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoaDonID = c.String(nullable: false, maxLength: 128),
                        KhachHangID = c.String(maxLength: 128),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HoaDonID)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangID)
                .Index(t => t.KhachHangID);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangID = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(nullable: false),
                        SDT = c.Int(nullable: false),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHangID", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHangID" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
        }
    }
}
