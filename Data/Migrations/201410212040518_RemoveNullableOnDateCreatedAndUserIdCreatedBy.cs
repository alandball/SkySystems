namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNullableOnDateCreatedAndUserIdCreatedBy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Address", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Address", "UserIdCreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Client", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Client", "UserIdCreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Authentication", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Authentication", "UserIdCreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "UserIdCreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Order", "UserIdCreatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "UserIdCreatedBy", c => c.Int());
            AlterColumn("dbo.Order", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.User", "UserIdCreatedBy", c => c.Int());
            AlterColumn("dbo.User", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Authentication", "UserIdCreatedBy", c => c.Int());
            AlterColumn("dbo.Authentication", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Client", "UserIdCreatedBy", c => c.Int());
            AlterColumn("dbo.Client", "DateCreated", c => c.DateTime());
            AlterColumn("dbo.Address", "UserIdCreatedBy", c => c.Int());
            AlterColumn("dbo.Address", "DateCreated", c => c.DateTime());
        }
    }
}
