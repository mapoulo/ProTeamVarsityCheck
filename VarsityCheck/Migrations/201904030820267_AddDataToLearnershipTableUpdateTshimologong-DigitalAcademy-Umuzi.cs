namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToLearnershipTableUpdateTshimologongDigitalAcademyUmuzi : DbMigration
    {
        public override void Up()
        {
            Sql("update Learnerships set LearnershipName = 'TSHIMOLOGONG IT LEARNERSHIP' WHERE id = 1");
            Sql("update Learnerships set LearnershipName = 'DIGITAL ACADEMY LEARNERSHIP' WHERE id = 2");
            Sql("update Learnerships set LearnershipName = 'UMUZI LEARNERSHIP' WHERE id = 3");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Learnerships WHERE id = 1");
            Sql("DELETE FROM Learnerships WHERE id = 2");
            Sql("DELETE FROM Learnerships WHERE id = 3");
        }
    }
}
