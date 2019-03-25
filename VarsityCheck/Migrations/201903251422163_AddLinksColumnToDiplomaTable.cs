namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinksColumnToDiplomaTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Diplomata", "Links", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Diplomata", "Links");
        }
    }
}
