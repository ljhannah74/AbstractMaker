namespace AbstractMaker.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeedEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TitleAbstractID = c.Int(nullable: false),
                        Grantee_Name = c.String(),
                        Grantor_Name = c.String(),
                        Ownership_Type = c.String(),
                        Other_Ownership_Type = c.String(),
                        Date = c.DateTime(),
                        Recorded = c.DateTime(),
                        Document_Series = c.String(),
                        Consideration = c.Decimal(precision: 18, scale: 2),
                        Book = c.String(),
                        Page = c.String(),
                        Misc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TitleAbstracts", "OrderStatus", c => c.String());
            AddColumn("dbo.TitleAbstracts", "DueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TitleAbstracts", "DueDate");
            DropColumn("dbo.TitleAbstracts", "OrderStatus");
            DropTable("dbo.Deeds");
        }
    }
}
