namespace PorticoRegistration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancedPatientPoco : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PatientID", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Patients", "LastName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Patients", "Suffix", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "FirstName", c => c.String(maxLength: 35));
            AlterColumn("dbo.Patients", "MiddleName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Patients", "SsnLastFour", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.Patients", "EmailAddress", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Patients", "UserToken", c => c.String(maxLength: 255));
            AlterColumn("dbo.Patients", "UserSecret", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "UserSecret", c => c.String());
            AlterColumn("dbo.Patients", "UserToken", c => c.String());
            AlterColumn("dbo.Patients", "EmailAddress", c => c.String());
            AlterColumn("dbo.Patients", "SsnLastFour", c => c.String());
            AlterColumn("dbo.Patients", "MiddleName", c => c.String());
            AlterColumn("dbo.Patients", "FirstName", c => c.String());
            AlterColumn("dbo.Patients", "Suffix", c => c.String());
            AlterColumn("dbo.Patients", "LastName", c => c.String());
            AlterColumn("dbo.Patients", "PatientID", c => c.String());
        }
    }
}
