namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertLinksColumnIntoUniversityTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Universities", "UrlHome", c => c.String());
            AddColumn("dbo.Universities", "UrlApply", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Universities", "UrlApply");
            DropColumn("dbo.Universities", "UrlHome");
        }
    }
}
