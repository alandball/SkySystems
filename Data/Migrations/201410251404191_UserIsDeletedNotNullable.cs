namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIsDeletedNotNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "IsDeleted", c => c.Boolean());
        }
    }
}
