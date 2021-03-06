namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToCertificatesTable3 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Certificates where id = 1");
            Sql("Delete from Certificates where id = 2");
            Sql("Delete from Certificates where id = 3");
            Sql("Delete from Certificates where id = 1002");
            Sql("Delete from Certificates where id = 1003");
            Sql("Delete from Certificates where id = 1004");
            Sql("DBCC CHECKIDENT('Certificates', RESEED, 0)");
            Sql("Insert Into Certificates Values('ComTia A+',3,1,'~/imgz/certificates/comptia.jpg')");
            Sql("Insert Into Certificates Values('OCA Java SE 8 Programmer ',3,1,'~/imgz/certificates/oca.jpg')");
            Sql("Insert Into Certificates Values('Microsoft Certificate Professional Databese ',3,1,'~/imgz/certificates/mcsa.jpg')");
        }
        
        public override void Down()
        {
            Sql("Delete from Certificates where id = 1");
            Sql("Delete from Certificates where id = 2");
            Sql("Delete from Certificates where id = 3");
        }
    }
}
