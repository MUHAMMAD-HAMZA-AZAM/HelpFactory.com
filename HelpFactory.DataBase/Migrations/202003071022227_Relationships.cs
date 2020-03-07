namespace HelpFactory.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.App_User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        ConfirmEmail = c.String(nullable: false),
                        Password = c.String(),
                        Mobilenumber = c.String(),
                        Address = c.String(),
                        WebsiteURL = c.String(nullable: false),
                        FaceBookPageURL = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Location_LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Locations", t => t.Location_LocationId)
                .Index(t => t.Location_LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        City_CityId = c.Int(),
                        Province_ProvinceId = c.Int(),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .Index(t => t.City_CityId)
                .Index(t => t.Province_ProvinceId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false),
                        CityCode = c.String(),
                        Province_ProvinceId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .Index(t => t.Province_ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(nullable: false),
                        ProvinceCode = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.ServiceCategory_User",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Serviceid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.Serviceid })
                .ForeignKey("dbo.App_User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceCategories", t => t.Serviceid, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Serviceid);
            
            CreateTable(
                "dbo.ServiceCategories",
                c => new
                    {
                        Serviceid = c.Int(nullable: false, identity: true),
                        Service_Name = c.String(nullable: false),
                        Service_code = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Serviceid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceCategory_User", "Serviceid", "dbo.ServiceCategories");
            DropForeignKey("dbo.ServiceCategory_User", "UserId", "dbo.App_User");
            DropForeignKey("dbo.Locations", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Cities", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Locations", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.App_User", "Location_LocationId", "dbo.Locations");
            DropIndex("dbo.ServiceCategory_User", new[] { "Serviceid" });
            DropIndex("dbo.ServiceCategory_User", new[] { "UserId" });
            DropIndex("dbo.Cities", new[] { "Province_ProvinceId" });
            DropIndex("dbo.Locations", new[] { "Province_ProvinceId" });
            DropIndex("dbo.Locations", new[] { "City_CityId" });
            DropIndex("dbo.App_User", new[] { "Location_LocationId" });
            DropTable("dbo.ServiceCategories");
            DropTable("dbo.ServiceCategory_User");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Locations");
            DropTable("dbo.App_User");
        }
    }
}
