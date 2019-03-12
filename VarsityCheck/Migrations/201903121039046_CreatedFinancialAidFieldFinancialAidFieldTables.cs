namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedFinancialAidFieldFinancialAidFieldTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FinancialAidFields",
                c => new
                    {
                        FinancialAidId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FinancialAidId, t.FieldId })
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .ForeignKey("dbo.FinancialAids", t => t.FinancialAidId, cascadeDelete: true)
                .Index(t => t.FinancialAidId)
                .Index(t => t.FieldId);
            
            CreateTable(
                "dbo.FinancialAids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        BursaryName = c.String(),
                        OpeningDate = c.DateTime(nullable: false),
                        ClosingDate = c.DateTime(nullable: false),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FinancialAidFields", "FinancialAidId", "dbo.FinancialAids");
            DropForeignKey("dbo.FinancialAidFields", "FieldId", "dbo.Fields");
            DropIndex("dbo.FinancialAidFields", new[] { "FieldId" });
            DropIndex("dbo.FinancialAidFields", new[] { "FinancialAidId" });
            DropTable("dbo.FinancialAids");
            DropTable("dbo.FinancialAidFields");
            DropTable("dbo.Fields");
        }
    }
}
