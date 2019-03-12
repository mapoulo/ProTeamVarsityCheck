namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDiplomaTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Diplomata Values( 'Mangement Services',5)");
            Sql("Insert Into Diplomata Values('Operations Management',5)");

        }

        public override void Down()
        {
            Sql("delete from Diplomata where name ='Mangement Services' ");
            Sql("delete from Diplomata where name ='Operations Management' ");
        }
    }
}
