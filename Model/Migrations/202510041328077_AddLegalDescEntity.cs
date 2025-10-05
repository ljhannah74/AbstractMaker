namespace AbstractMaker.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLegalDescEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Legal_Description",
                c => new
                    {
                        Legal_DescriptionID = c.Int(nullable: false, identity: true),
                        TitleAbstractID = c.Int(nullable: false),
                        Text = c.String(),
                        PB_Legal_Description = c.Boolean(nullable: false),
                        TaxID = c.String(),
                    })
                .PrimaryKey(t => t.Legal_DescriptionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Legal_Description");
        }
    }
}
