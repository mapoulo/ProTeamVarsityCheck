namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiplomaTableToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diplomata",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SchoolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diplomata", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Diplomata", new[] { "SchoolId" });
            DropTable("dbo.Diplomata");
        }
    }
}
