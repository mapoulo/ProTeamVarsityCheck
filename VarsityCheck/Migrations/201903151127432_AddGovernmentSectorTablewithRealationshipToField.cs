namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGovernmentSectorTablewithRealationshipToField : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GovernmentSectorFields",
                c => new
                    {
                        GovernmentId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GovernmentId, t.FieldId })
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .ForeignKey("dbo.GovernmentSectors", t => t.GovernmentId, cascadeDelete: true)
                .Index(t => t.GovernmentId)
                .Index(t => t.FieldId);
            
            CreateTable(
                "dbo.GovernmentSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OpeningDate = c.DateTime(nullable: false),
                        ClosingDate = c.DateTime(nullable: false),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GovernmentSectorFields", "GovernmentId", "dbo.GovernmentSectors");
            DropForeignKey("dbo.GovernmentSectorFields", "FieldId", "dbo.Fields");
            DropIndex("dbo.GovernmentSectorFields", new[] { "FieldId" });
            DropIndex("dbo.GovernmentSectorFields", new[] { "GovernmentId" });
            DropTable("dbo.GovernmentSectors");
            DropTable("dbo.GovernmentSectorFields");
        }
    }
}
