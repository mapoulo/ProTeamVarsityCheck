namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class jjjjjjjjjjjjj : DbMigration
    {
        public override void Up()
        {
            Sql("1,1,'development of graduates who possess the ability to solve complex engineering problems.','https://www.uj.ac.za/faculties/febe/School%20of%20Electrical%20Engineering/Pages/eeec-about.aspx')");
        }
        public override void Down()
        {
            Sql("Delete from Discriptions where id = 1");

        }
    }
}