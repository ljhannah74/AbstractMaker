namespace AbstractMaker.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.ClientID);
            
            CreateTable(
                "dbo.TitleAbstracts",
                c => new
                    {
                        TitleAbstractID = c.Int(nullable: false, identity: true),
                        OrderNo = c.String(),
                        SearchDate = c.DateTime(nullable: false),
                        EffectiveDate = c.DateTime(nullable: false),
                        ClientRefNo = c.String(),
                        Client_ClientID = c.Int(),
                        ProductType_ProductTypeID = c.Int(),
                        Property_PropertyID = c.Int(),
                    })
                .PrimaryKey(t => t.TitleAbstractID)
                .ForeignKey("dbo.Clients", t => t.Client_ClientID)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_ProductTypeID)
                .ForeignKey("dbo.Properties", t => t.Property_PropertyID)
                .Index(t => t.Client_ClientID)
                .Index(t => t.ProductType_ProductTypeID)
                .Index(t => t.Property_PropertyID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeID = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PropertyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TitleAbstracts", "Property_PropertyID", "dbo.Properties");
            DropForeignKey("dbo.TitleAbstracts", "ProductType_ProductTypeID", "dbo.ProductTypes");
            DropForeignKey("dbo.TitleAbstracts", "Client_ClientID", "dbo.Clients");
            DropIndex("dbo.TitleAbstracts", new[] { "Property_PropertyID" });
            DropIndex("dbo.TitleAbstracts", new[] { "ProductType_ProductTypeID" });
            DropIndex("dbo.TitleAbstracts", new[] { "Client_ClientID" });
            DropTable("dbo.Properties");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.TitleAbstracts");
            DropTable("dbo.Clients");
        }
    }
}
