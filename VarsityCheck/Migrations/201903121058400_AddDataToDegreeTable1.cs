namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDegreeTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Degrees Values('Electrical Engineering',1)");
            Sql("Insert Into Degrees Values('Civil Engineering',2)");
            Sql("Insert Into Degrees Values('Industrial Engineering',3)");
            Sql("Insert Into Degrees Values('Mining Engineering',4)");
            Sql("Insert Into Degrees Values('Mechanical Engineering',3)");
            Sql("Insert Into Degrees Values('Chemical Engineering',4)");
            Sql("Insert Into Degrees Values('Extraction Metallurgy',4)");
            Sql("Insert Into Degrees Values('Physical Metallurgy',4)");
        }

        public override void Down()
        {
            Sql("delete from Degrees where name ='Electrical Engineering' ");
            Sql("delete from Degrees where name ='Civil Engineering' ");
            Sql("delete from Degrees where name ='Industrial Engineering' ");
            Sql("delete from Degrees where name ='Mining Engineering' ");
            Sql("delete from Degrees where name ='Mechanical Engineering' ");
            Sql("delete from Degrees where name ='Chemical Engineering' ");
            Sql("delete from Degrees where name ='Extraction Metallurgy' ");
            Sql("delete from Degrees where name ='Physical Metallurgy' ");
        }
    }
}
