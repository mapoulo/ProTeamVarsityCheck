namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLearnershipsNamesToLearnershipTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Learnerships", "LearnershipNames", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Learnerships", "LearnershipNames");
        }
    }
}
