namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnLearnershipsNameToLearnershipsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Learnerships", "LearnershipsName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Learnerships", "LearnershipsName", c => c.String());
        }
    }
}
