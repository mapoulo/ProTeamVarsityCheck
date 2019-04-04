namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnLearnershipNameToLearnershipsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Learnerships", "LearnershipsName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Learnerships", "LearnershipsName");
        }
    }
}
