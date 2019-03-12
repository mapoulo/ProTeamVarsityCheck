namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToSchoolsTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Schools Values('Electrical Engineering',3)");
            Sql("Insert Into Schools Values('Civil Engineering and the Built Environment',3)");
            Sql("Insert Into Schools Values('Mechanical and Industrial Engineering',3)");
            Sql("Insert Into Schools Values('Mining, Metallurgy and Chemical Engineering ',3)");
            Sql("Insert Into Schools Values('Engineering Management',3)");
        }

        public override void Down()
        {
            Sql("delete from Schools where name ='Electrical Engineering' ");
            Sql("delete from Schools where name ='Civil Engineering and the Built Environment' ");
            Sql("delete from Schools where name ='Mechanical and Industrial Engineering' ");
            Sql("delete from Schools where name ='Mining, Metallurgy and Chemical Engineering ' ");
            Sql("delete from Schools where name ='Engineering Management' ");
        }
    }
}
