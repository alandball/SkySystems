namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderTableDateDeliveredAndDateToBeDelivered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "DateToBeDelivered", c => c.DateTime(nullable: false));
            AddColumn("dbo.Order", "DateDelivered", c => c.DateTime());
            DropColumn("dbo.Order", "DeliveryDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "DeliveryDate", c => c.DateTime());
            DropColumn("dbo.Order", "DateDelivered");
            DropColumn("dbo.Order", "DateToBeDelivered");
        }
    }
}
