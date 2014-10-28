namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStockLogOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StockLogOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.StockLogOrder", "StockId", "dbo.StockLog");
            DropIndex("dbo.StockLogOrder", new[] { "OrderId" });
            DropIndex("dbo.StockLogOrder", new[] { "StockId" });
            DropTable("dbo.StockLogOrder");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StockLogOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.StockLogOrder", "StockId");
            CreateIndex("dbo.StockLogOrder", "OrderId");
            AddForeignKey("dbo.StockLogOrder", "StockId", "dbo.StockLog", "Id");
            AddForeignKey("dbo.StockLogOrder", "OrderId", "dbo.Order", "Id");
        }
    }
}
