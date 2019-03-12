namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDegreeTableToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Degrees",
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
            DropForeignKey("dbo.Degrees", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Degrees", new[] { "SchoolId" });
            DropTable("dbo.Degrees");
        }
    }
}
