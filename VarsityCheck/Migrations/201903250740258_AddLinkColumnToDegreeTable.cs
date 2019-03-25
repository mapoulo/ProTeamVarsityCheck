namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkColumnToDegreeTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Degrees ADD Link VARCHAR(50)");
        }
        
        public override void Down()
        {
            Sql("ALTER TABLE Degrees DROP COLUMN Link");
        }
    }
}
