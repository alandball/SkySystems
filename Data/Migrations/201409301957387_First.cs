namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Birthdate = c.DateTime(),
                        HomeAddress1 = c.String(),
                        HomeAddress2 = c.String(),
                        HomeAddress3 = c.String(),
                        HomeAddressPostalCode = c.String(),
                        PostalAddress1 = c.String(),
                        PostalAddress2 = c.String(),
                        PostalAddress3 = c.String(),
                        PostalAddressPostalCode = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        CellPhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        NationalId = c.String(),
                        DateCreated = c.DateTime(),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.UserType", t => t.UserTypeId)
                .Index(t => t.BranchId)
                .Index(t => t.UserTypeId);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserTypeId", "dbo.UserType");
            DropForeignKey("dbo.User", "BranchId", "dbo.Branch");
            DropIndex("dbo.User", new[] { "UserTypeId" });
            DropIndex("dbo.User", new[] { "BranchId" });
            DropTable("dbo.UserType");
            DropTable("dbo.Branch");
            DropTable("dbo.User");
        }
    }
}
