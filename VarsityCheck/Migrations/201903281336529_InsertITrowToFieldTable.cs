namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertITrowToFieldTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Fields values ('Information Technolgy','~/imgz/fields/IT.jpg')");
        }
        
        public override void Down()
        {
            Sql("Delete from Fields where id = 3");
        }
    }
}
