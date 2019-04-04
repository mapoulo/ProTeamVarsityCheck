namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateLearnershipPCW : DbMigration
    {
        public override void Up()
        {
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING MAFIKENG/LICHTENBURG' WHERE id = 16");
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING DURBAN' WHERE id = 17");
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING PORT ELIZABETH' WHERE id = 18");
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING EAST LONDON' WHERE id = 19");
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING BLOEMFONTEIN' WHERE id = 20");
            Sql("update Learnerships set LearnershipName = 'FINANCE TRAINING CAPE TOWN' WHERE id = 21");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Learnerships WHERE id = 16");
            Sql("DELETE FROM Learnerships WHERE id = 17");
            Sql("DELETE FROM Learnerships WHERE id = 18");
            Sql("DELETE FROM Learnerships WHERE id = 19");
            Sql("DELETE FROM Learnerships WHERE id = 20");
            Sql("DELETE FROM Learnerships WHERE id = 21");
        }
    }
}
