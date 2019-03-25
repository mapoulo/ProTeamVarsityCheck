namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToLinksColumnInDiplomaTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Diplomata set Links = 'Mangement', Image = '~/imgz/Diploma/management.jpg' where Id = 1");
            Sql("Update Diplomata set Links = 'Operations', Image = '~/imgz/Diploma/operations.jpg' where Id = 2");
        }
        
        public override void Down()
        {
            Sql("Delete from Diplomata where Id = 1");
            Sql("Delete from Diplomata where Id = 2");
        }
    }
}
