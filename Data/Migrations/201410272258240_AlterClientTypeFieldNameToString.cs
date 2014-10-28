namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterClientTypeFieldNameToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientType", "Name", c => c.String());
            DropColumn("dbo.ClientType", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientType", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.ClientType", "Name");
        }
    }
}
