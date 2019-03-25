namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertLinksColumnIntoUniversityFacultiesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UniversityFaculties", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UniversityFaculties", "Url");
        }
    }
}
