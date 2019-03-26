namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUrlApplyColumnToLearnershipTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Learnerships", "UrlApply", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Learnerships", "UrlApply");
        }
    }
}
