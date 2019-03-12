namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolTableToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UniversityFaculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false),
                        UniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FacultyId, t.UniversityId })
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schools", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.UniversityFaculties", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.UniversityFaculties", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.Schools", new[] { "FacultyId" });
            DropIndex("dbo.UniversityFaculties", new[] { "UniversityId" });
            DropIndex("dbo.UniversityFaculties", new[] { "FacultyId" });
            DropTable("dbo.Schools");
            DropTable("dbo.UniversityFaculties");
        }
    }
}
