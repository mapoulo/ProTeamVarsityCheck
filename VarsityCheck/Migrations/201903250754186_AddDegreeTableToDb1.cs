namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDegreeTableToDb1 : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.Degrees", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Degrees", "Links", c => c.String());
        }
    }
}
