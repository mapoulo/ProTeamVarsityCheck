namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToUniversityTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Universities values('University of Johannesburg','Gauteng')");
            Sql("INSERT INTO Universities values('University of Cape Town','Western Cape')");
            Sql("INSERT INTO Universities values('University of Limpopo','Limpopo')");
            Sql("INSERT INTO Universities values('University of KwaZulu-Natal','KwaZulu-Natal')");
        }

        public override void Down()
        {
            Sql("delete from Universities where name ='University of Johannesburg' ");
            Sql("delete from Universities where name ='University of Cape Town' ");
            Sql("delete from Universities where name ='University of Limpopo' ");
            Sql("delete from Universities where name ='University of KwaZulu-Natal' ");
        }
    }
}
