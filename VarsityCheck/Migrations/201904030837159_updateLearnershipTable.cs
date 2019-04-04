namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateLearnershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("update Learnerships set LearnershipName = 'ELECTRICAL ENGINEERING' WHERE id = 9");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Learnerships WHERE id = 9");
        }
    }
}
