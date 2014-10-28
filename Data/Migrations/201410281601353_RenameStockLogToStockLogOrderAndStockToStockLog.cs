namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameStockLogToStockLogOrderAndStockToStockLog : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stock", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.StockLog", "OrderId", "dbo.Order");
            DropForeignKey("dbo.StockLog", "StockId", "dbo.Stock");
            DropIndex("dbo.Stock", new[] { "BranchId" });
            DropIndex("dbo.StockLog", new[] { "OrderId" });
            DropIndex("dbo.StockLog", new[] { "StockId" });
            CreateTable(
                "dbo.StockLogOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId)
                .ForeignKey("dbo.StockLog", t => t.StockId)
                .Index(t => t.OrderId)
                .Index(t => t.StockId);
            
            AddColumn("dbo.StockLog", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.StockLog", "Quantity", c => c.Double(nullable: false));
            AddColumn("dbo.StockLog", "InOut", c => c.Double(nullable: false));
            AddColumn("dbo.StockLog", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.StockLog", "DateLastModified", c => c.DateTime());
            AddColumn("dbo.StockLog", "DateDeleted", c => c.DateTime());
            AddColumn("dbo.StockLog", "UserIdCreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.StockLog", "UserIdLastModifiedBy", c => c.Int());
            AddColumn("dbo.StockLog", "UserIdDeletedBy", c => c.Int());
            AddColumn("dbo.StockLog", "IsDeleted", c => c.Boolean(nullable: false));
            CreateIndex("dbo.StockLog", "BranchId");
            AddForeignKey("dbo.StockLog", "BranchId", "dbo.Branch", "Id");
            DropColumn("dbo.StockLog", "OrderId");
            DropColumn("dbo.StockLog", "StockId");
            DropTable("dbo.Stock");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                        InOut = c.Double(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(nullable: false),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.StockLog", "StockId", c => c.Int(nullable: false));
            AddColumn("dbo.StockLog", "OrderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.StockLogOrder", "StockId", "dbo.StockLog");
            DropForeignKey("dbo.StockLogOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.StockLog", "BranchId", "dbo.Branch");
            DropIndex("dbo.StockLogOrder", new[] { "StockId" });
            DropIndex("dbo.StockLogOrder", new[] { "OrderId" });
            DropIndex("dbo.StockLog", new[] { "BranchId" });
            DropColumn("dbo.StockLog", "IsDeleted");
            DropColumn("dbo.StockLog", "UserIdDeletedBy");
            DropColumn("dbo.StockLog", "UserIdLastModifiedBy");
            DropColumn("dbo.StockLog", "UserIdCreatedBy");
            DropColumn("dbo.StockLog", "DateDeleted");
            DropColumn("dbo.StockLog", "DateLastModified");
            DropColumn("dbo.StockLog", "DateCreated");
            DropColumn("dbo.StockLog", "InOut");
            DropColumn("dbo.StockLog", "Quantity");
            DropColumn("dbo.StockLog", "BranchId");
            DropTable("dbo.StockLogOrder");
            CreateIndex("dbo.StockLog", "StockId");
            CreateIndex("dbo.StockLog", "OrderId");
            CreateIndex("dbo.Stock", "BranchId");
            AddForeignKey("dbo.StockLog", "StockId", "dbo.Stock", "Id");
            AddForeignKey("dbo.StockLog", "OrderId", "dbo.Order", "Id");
            AddForeignKey("dbo.Stock", "BranchId", "dbo.Branch", "Id");
        }
    }
}
