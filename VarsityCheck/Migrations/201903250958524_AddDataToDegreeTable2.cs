namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDegreeTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Degrees', RESEED, 0)");


            Sql("Insert Into Degrees Values('Electrical Engineering',1,'~/imgz/degrees/engineering/electrical.jpg','Electrical')");
            Sql("Insert Into Degrees Values('Civil Engineering',2,'~/imgz/degrees/engineering/civil.jpg' , 'Civil')");
            Sql("Insert Into Degrees Values('Industrial Engineering',3,'~/imgz/degrees/engineering/industrial.jpg','Industrial')");
            Sql("Insert Into Degrees Values('Mining Engineering',4,'~/imgz/degrees/engineering/Mining.jpg', 'Mining')");
            Sql("Insert Into Degrees Values('Mechanical Engineering',3,'~/imgz/degrees/engineering/mechanical.jpg','Mechanical')");
            Sql("Insert Into Degrees Values('Chemical Engineering',4,'~/imgz/degrees/engineering/Chemical.jpg' ,'Chemical')");
            Sql("Insert Into Degrees Values('Extraction Metallurgy',4,'~/imgz/degrees/engineering/extraction.jpg' ,'Extraction')");
            Sql("Insert Into Degrees Values('Physical Metallurgy',4,'~/imgz/degrees/engineering/physical.jpg' ,'Physical')");
           
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
