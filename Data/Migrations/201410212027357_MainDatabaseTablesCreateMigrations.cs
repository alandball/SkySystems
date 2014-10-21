namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MainDatabaseTablesCreateMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        AddressTypeId = c.Int(nullable: false),
                        PostalCode = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        AddressLine3 = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        DateCreated = c.DateTime(),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AddressType", t => t.AddressTypeId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId)
                .Index(t => t.AddressTypeId);
            
            CreateTable(
                "dbo.AddressType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientTypeId = c.Int(nullable: false),
                        CompanyName = c.String(),
                        Email = c.String(),
                        Tel1 = c.String(),
                        Tel2 = c.String(),
                        DateCreated = c.DateTime(),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientType", t => t.ClientTypeId)
                .Index(t => t.ClientTypeId);
            
            CreateTable(
                "dbo.ClientType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authentication",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        DateCreated = c.DateTime(),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        GoogleMapLink = c.String(),
                        DeliveryDate = c.DateTime(),
                        OrderDate = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(),
                        DateLastModified = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        UserIdCreatedBy = c.Int(),
                        UserIdLastModifiedBy = c.Int(),
                        UserIdDeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.User", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "UserName", c => c.String());
            DropForeignKey("dbo.Order", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Order", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Authentication", "UserId", "dbo.User");
            DropForeignKey("dbo.Address", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Client", "ClientTypeId", "dbo.ClientType");
            DropForeignKey("dbo.Address", "AddressTypeId", "dbo.AddressType");
            DropIndex("dbo.Order", new[] { "AddressId" });
            DropIndex("dbo.Order", new[] { "ClientId" });
            DropIndex("dbo.Authentication", new[] { "UserId" });
            DropIndex("dbo.Client", new[] { "ClientTypeId" });
            DropIndex("dbo.Address", new[] { "AddressTypeId" });
            DropIndex("dbo.Address", new[] { "ClientId" });
            DropTable("dbo.Stock");
            DropTable("dbo.Order");
            DropTable("dbo.Authentication");
            DropTable("dbo.ClientType");
            DropTable("dbo.Client");
            DropTable("dbo.AddressType");
            DropTable("dbo.Address");
        }
    }
}
