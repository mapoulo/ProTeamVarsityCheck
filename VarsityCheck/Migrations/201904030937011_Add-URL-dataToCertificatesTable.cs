namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURLdataToCertificatesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certificates", "URLs", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Certificates", "URLs");
        }
    }
}
