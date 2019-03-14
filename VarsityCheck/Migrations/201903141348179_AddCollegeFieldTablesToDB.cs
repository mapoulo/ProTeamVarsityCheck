namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCollegeFieldTablesToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CollegeFields",
                c => new
                    {
                        CollegeId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CollegeId, t.FieldId })
                .ForeignKey("dbo.Colleges", t => t.CollegeId, cascadeDelete: true)
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .Index(t => t.CollegeId)
                .Index(t => t.FieldId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CollegeFields", "FieldId", "dbo.Fields");
            DropForeignKey("dbo.CollegeFields", "CollegeId", "dbo.Colleges");
            DropIndex("dbo.CollegeFields", new[] { "FieldId" });
            DropIndex("dbo.CollegeFields", new[] { "CollegeId" });
            DropTable("dbo.CollegeFields");
        }
    }
}
