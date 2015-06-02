namespace PorticoRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameFirstNameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "FirstName", c => c.String());
            DropColumn("dbo.Patients", "FirstNae");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "FirstNae", c => c.String());
            DropColumn("dbo.Patients", "FirstName");
        }
    }
}
