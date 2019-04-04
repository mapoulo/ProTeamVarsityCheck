namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrlColumnToCertificatesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Certificates add URL varchar(70)");
        }
        
        public override void Down()
        {
            Sql("Alter table Certificates Drop column URL");
        }
    }
}
