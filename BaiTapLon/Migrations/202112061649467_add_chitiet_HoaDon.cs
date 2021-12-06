namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_chitiet_HoaDon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "Chitiet", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "Chitiet");
        }
    }
}
