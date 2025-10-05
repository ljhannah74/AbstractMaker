namespace AbstractMaker.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "Address", c => c.String());
            AddColumn("dbo.Properties", "Address2", c => c.String());
            AddColumn("dbo.Properties", "City", c => c.String());
            AddColumn("dbo.Properties", "State", c => c.String());
            AddColumn("dbo.Properties", "PostalCode", c => c.String());
            AddColumn("dbo.Properties", "County", c => c.String());
            AddColumn("dbo.Properties", "PropertyType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "PropertyType");
            DropColumn("dbo.Properties", "County");
            DropColumn("dbo.Properties", "PostalCode");
            DropColumn("dbo.Properties", "State");
            DropColumn("dbo.Properties", "City");
            DropColumn("dbo.Properties", "Address2");
            DropColumn("dbo.Properties", "Address");
        }
    }
}
