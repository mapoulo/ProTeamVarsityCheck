namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToUniversityFacultyTableVersion2 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into UniversityFaculties values(1,1)");
            Sql("Insert into UniversityFaculties values(1,2)");
            Sql("Insert into UniversityFaculties values(1,3)");
            Sql("Insert into UniversityFaculties values(1,4)");


            Sql("Insert into UniversityFaculties values(2,1)");
            Sql("Insert into UniversityFaculties values(2,2)");
            Sql("Insert into UniversityFaculties values(2,3)");
            Sql("Insert into UniversityFaculties values(2,4)");

            Sql("Insert into UniversityFaculties values(3,1)");
            Sql("Insert into UniversityFaculties values(3,2)");
            Sql("Insert into UniversityFaculties values(3,3)");
            Sql("Insert into UniversityFaculties values(3,4)");

            Sql("Insert into UniversityFaculties values(4,1)");
            Sql("Insert into UniversityFaculties values(4,2)");
            Sql("Insert into UniversityFaculties values(4,3)");
            Sql("Insert into UniversityFaculties values(4,4)");
        }

        public override void Down()
        {
            Sql("delete from UniversityFaculties where FacultyId = 1 AND UniversityId = 1");
            Sql("delete from UniversityFaculties where FacultyId = 1 AND UniversityId = 2");
            Sql("delete from UniversityFaculties where FacultyId = 1 AND UniversityId = 3");
            Sql("delete from UniversityFaculties where FacultyId = 1 AND UniversityId = 4");

            Sql("delete from UniversityFaculties where FacultyId = 2 AND UniversityId = 1");
            Sql("delete from UniversityFaculties where FacultyId = 2 AND UniversityId = 2");
            Sql("delete from UniversityFaculties where FacultyId = 2 AND UniversityId = 3");
            Sql("delete from UniversityFaculties where FacultyId = 2 AND UniversityId = 4");

            Sql("delete from UniversityFaculties where FacultyId = 3 AND UniversityId = 1");
            Sql("delete from UniversityFaculties where FacultyId = 3 AND UniversityId = 2");
            Sql("delete from UniversityFaculties where FacultyId = 3 AND UniversityId = 3");
            Sql("delete from UniversityFaculties where FacultyId = 3 AND UniversityId = 4");

            Sql("delete from UniversityFaculties where FacultyId = 4 AND UniversityId = 1");
            Sql("delete from UniversityFaculties where FacultyId = 4 AND UniversityId = 2");
            Sql("delete from UniversityFaculties where FacultyId = 4 AND UniversityId = 3");
            Sql("delete from UniversityFaculties where FacultyId = 4 AND UniversityId = 4");
        }
    }
}
