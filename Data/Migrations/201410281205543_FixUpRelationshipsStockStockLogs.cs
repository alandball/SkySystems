namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixUpRelationshipsStockStockLogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId)
                .ForeignKey("dbo.Stock", t => t.StockId)
                .Index(t => t.OrderId)
                .Index(t => t.StockId);
            
            AddColumn("dbo.Order", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.Stock", "BranchId", c => c.Int(nullable: false));
            AddColumn("dbo.Stock", "InOut", c => c.Double(nullable: false));
            AddColumn("dbo.Stock", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Stock", "DateLastModified", c => c.DateTime());
            AddColumn("dbo.Stock", "DateDeleted", c => c.DateTime());
            AddColumn("dbo.Stock", "UserIdCreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Stock", "UserIdLastModifiedBy", c => c.Int());
            AddColumn("dbo.Stock", "UserIdDeletedBy", c => c.Int());
            AddColumn("dbo.Stock", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Stock", "Quantity", c => c.Double(nullable: false));
            CreateIndex("dbo.Order", "BranchId");
            CreateIndex("dbo.Stock", "BranchId");
            AddForeignKey("dbo.Order", "BranchId", "dbo.Branch", "Id");
            AddForeignKey("dbo.Stock", "BranchId", "dbo.Branch", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockLog", "StockId", "dbo.Stock");
            DropForeignKey("dbo.StockLog", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Stock", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Order", "BranchId", "dbo.Branch");
            DropIndex("dbo.StockLog", new[] { "StockId" });
            DropIndex("dbo.StockLog", new[] { "OrderId" });
            DropIndex("dbo.Stock", new[] { "BranchId" });
            DropIndex("dbo.Order", new[] { "BranchId" });
            AlterColumn("dbo.Stock", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Stock", "IsDeleted");
            DropColumn("dbo.Stock", "UserIdDeletedBy");
            DropColumn("dbo.Stock", "UserIdLastModifiedBy");
            DropColumn("dbo.Stock", "UserIdCreatedBy");
            DropColumn("dbo.Stock", "DateDeleted");
            DropColumn("dbo.Stock", "DateLastModified");
            DropColumn("dbo.Stock", "DateCreated");
            DropColumn("dbo.Stock", "InOut");
            DropColumn("dbo.Stock", "BranchId");
            DropColumn("dbo.Order", "BranchId");
            DropTable("dbo.StockLog");
        }
    }
}
