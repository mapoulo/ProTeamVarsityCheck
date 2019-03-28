namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddITDataToCertificatesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Alter table Certificates Alter column  Name varchar(20)");
            
        }
        
        public override void Down()
        {
           
        }
    }
}
