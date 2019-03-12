namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToFieldTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Fields values('Accounting')");
            Sql("insert into Fields values('Fashion/Textile Design')");
        }

        public override void Down()
        {
            Sql("delete from Fields where Name='Accounting'");
            Sql("delete from Fields where Name='Fashion/Textile Design'");
        }
    }
}
