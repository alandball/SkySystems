namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTweaksToStockAndOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "StockLogId", c => c.Int(nullable: false));
            CreateIndex("dbo.Order", "StockLogId");
            AddForeignKey("dbo.Order", "StockLogId", "dbo.StockLog", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "StockLogId", "dbo.StockLog");
            DropIndex("dbo.Order", new[] { "StockLogId" });
            DropColumn("dbo.Order", "StockLogId");
        }
    }
}
