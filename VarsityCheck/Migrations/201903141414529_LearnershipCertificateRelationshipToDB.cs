namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LearnershipCertificateRelationshipToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LearnershipCertificates",
                c => new
                    {
                        CertificateId = c.Int(nullable: false),
                        LearnershipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CertificateId, t.LearnershipId })
                .ForeignKey("dbo.Certificates", t => t.CertificateId, cascadeDelete: true)
                .ForeignKey("dbo.Learnerships", t => t.LearnershipId, cascadeDelete: true)
                .Index(t => t.CertificateId)
                .Index(t => t.LearnershipId);
            
            AddColumn("dbo.Certificates", "FieldId", c => c.Int(nullable: false));
            AddColumn("dbo.Certificates", "Learnership_Id", c => c.Int());
            CreateIndex("dbo.Certificates", "FieldId");
            CreateIndex("dbo.Certificates", "Learnership_Id");
            AddForeignKey("dbo.Certificates", "FieldId", "dbo.Fields", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Certificates", "Learnership_Id", "dbo.Learnerships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LearnershipCertificates", "LearnershipId", "dbo.Learnerships");
            DropForeignKey("dbo.Certificates", "Learnership_Id", "dbo.Learnerships");
            DropForeignKey("dbo.LearnershipCertificates", "CertificateId", "dbo.Certificates");
            DropForeignKey("dbo.Certificates", "FieldId", "dbo.Fields");
            DropIndex("dbo.LearnershipCertificates", new[] { "LearnershipId" });
            DropIndex("dbo.LearnershipCertificates", new[] { "CertificateId" });
            DropIndex("dbo.Certificates", new[] { "Learnership_Id" });
            DropIndex("dbo.Certificates", new[] { "FieldId" });
            DropColumn("dbo.Certificates", "Learnership_Id");
            DropColumn("dbo.Certificates", "FieldId");
            DropTable("dbo.LearnershipCertificates");
        }
    }
}
