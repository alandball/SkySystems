namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNameToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "UserName");
        }
    }
}
