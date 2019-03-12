namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToFacultyTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Faculties Values('Health Sciences')");
            Sql("Insert Into Faculties Values('Education')");
            Sql("Insert Into Faculties Values('Engineering')");
            Sql("Insert Into Faculties Values('Humanities')");
        }

        public override void Down()
        {
            Sql("delete from Faculties where name ='Health Sciences' ");
            Sql("delete from Faculties where name ='Education' ");
            Sql("delete from Faculties where name ='Engineering' ");
            Sql("delete from Faculties where name ='Humanities' ");
        }
    }
}
