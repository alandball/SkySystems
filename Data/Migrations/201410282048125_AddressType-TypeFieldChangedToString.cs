namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressTypeTypeFieldChangedToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressType", "Type", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddressType", "Type", c => c.Int(nullable: false));
        }
    }
}
