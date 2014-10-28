namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTweaksToOrderStockAndLog : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Order", "Quantity");
            DropColumn("dbo.StockLog", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockLog", "Quantity", c => c.Double(nullable: false));
            AddColumn("dbo.Order", "Quantity", c => c.Int(nullable: false));
        }
    }
}
