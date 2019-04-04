namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataTolearnershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("update Learnerships set LearnershipNames = 'Tshimologong IT Learnership' where Id = 1");
            Sql("update Learnerships set LearnershipNames = 'Digital Academy Learnership' where Id = 2");
            Sql("update Learnerships set LearnershipNames = 'Umuzi Learnership' where Id = 3");
            Sql("update Learnerships set LearnershipNames = 'Aviation Learnership' where Id = 4");
            Sql("update Learnerships set LearnershipNames = 'Track Master Apprenticeship' where Id = 5");
            Sql("update Learnerships set LearnershipNames = 'Traction Lineman Apprenticeship' where Id = 6");
            Sql("update Learnerships set LearnershipNames = 'Welder Apprenticeship' where Id = 7");
            Sql("update Learnerships set LearnershipNames = 'Boilermaking' where Id = 8");
            Sql("update Learnerships set LearnershipNames = 'ELECTRICAL ENGINEERING' where Id = 9");
            Sql("update Learnerships set LearnershipNames = 'Fitting and Turning' where Id = 10");
            Sql("update Learnerships set LearnershipNames = 'Pupil Geomatics Officer' where Id = 11");
            Sql("update Learnerships set LearnershipNames = 'Forensic Accountancy' where Id = 12");
            Sql("update Learnerships set LearnershipNames = 'Chemical / Mechanical Engineering' where Id = 13");
            Sql("update Learnerships set LearnershipNames = 'Taxation / Accounting Graduate' where Id = 14");
            Sql("update Learnerships set LearnershipNames = 'IT Infrastructure & Cloud Computing Technologies' where Id = 15");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING MAFIKENG/LICHTENBURG' where Id = 16");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING DURBAN' where Id = 17");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING PORT ELIZABETH' where Id = 18");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING EAST LONDON' where Id = 19");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING BLOEMFONTEIN' where Id = 20");
            Sql("update Learnerships set LearnershipNames = 'FINANCE TRAINING CAPE TOWN' where Id = 21");
        }

        public override void Down()
        {
            Sql("delete from Learnerships where id = 1");
            Sql("delete from Learnerships where id = 2");
            Sql("delete from Learnerships where id = 3");
            Sql("delete from Learnerships where id = 4");
            Sql("delete from Learnerships where id = 5");
            Sql("delete from Learnerships where id = 6");
            Sql("delete from Learnerships where id = 7");
            Sql("delete from Learnerships where id = 8");
            Sql("delete from Learnerships where id = 9");
            Sql("delete from Learnerships where id = 10");
            Sql("delete from Learnerships where id = 11");
            Sql("delete from Learnerships where id = 12");
            Sql("delete from Learnerships where id = 13");
            Sql("delete from Learnerships where id = 14");
            Sql("delete from Learnerships where id = 15");
            Sql("delete from Learnerships where id = 16");
            Sql("delete from Learnerships where id = 17");
            Sql("delete from Learnerships where id = 18");
            Sql("delete from Learnerships where id = 19");
            Sql("delete from Learnerships where id = 20");
            Sql("delete from Learnerships where id = 21");
        }
    }
}
