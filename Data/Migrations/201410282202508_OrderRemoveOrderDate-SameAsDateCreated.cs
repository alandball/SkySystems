namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRemoveOrderDateSameAsDateCreated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Order", "OrderDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "OrderDate", c => c.DateTime());
        }
    }
}
