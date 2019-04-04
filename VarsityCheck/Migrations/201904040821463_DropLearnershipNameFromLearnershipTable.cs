namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropLearnershipNameFromLearnershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Learnerships Drop column LearnershipName");
        }
        
        public override void Down()
        {
        }
    }
}
