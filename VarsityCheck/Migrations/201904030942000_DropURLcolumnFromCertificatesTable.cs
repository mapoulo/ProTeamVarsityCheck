namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropURLcolumnFromCertificatesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Certificates", "URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Certificates", "URLs", c => c.String());
        }
    }
}
