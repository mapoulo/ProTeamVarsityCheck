namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiplomaTableToDb1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Diplomata", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Diplomata", new[] { "SchoolId" });
            AlterColumn("dbo.Diplomata", "SchoolId", c => c.Int());
            CreateIndex("dbo.Diplomata", "SchoolId");
            AddForeignKey("dbo.Diplomata", "SchoolId", "dbo.Schools", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diplomata", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Diplomata", new[] { "SchoolId" });
            AlterColumn("dbo.Diplomata", "SchoolId", c => c.Int(nullable: false));
            CreateIndex("dbo.Diplomata", "SchoolId");
            AddForeignKey("dbo.Diplomata", "SchoolId", "dbo.Schools", "Id", cascadeDelete: true);
        }
    }
}
