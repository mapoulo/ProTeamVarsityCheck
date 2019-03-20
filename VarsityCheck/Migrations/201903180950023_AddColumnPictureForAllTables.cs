namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnPictureForAllTables : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Certificates ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Colleges ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Degrees ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Diplomata ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Faculties ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Fields ADD Image VARCHAR(255)");
            Sql("ALTER TABLE FinancialAids ADD Image VARCHAR(255)");
            Sql("ALTER TABLE GovernmentSectors ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Learnerships ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Schools ADD Image VARCHAR(255)");
            Sql("ALTER TABLE Universities ADD Image VARCHAR(255)");
            
            
        }
        
        public override void Down()
        {
            Sql("ALTER TABLE Certificates DROP Image");
            Sql("ALTER TABLE Colleges DROP Image");
            Sql("ALTER TABLE Degrees DROP Image");
            Sql("ALTER TABLE Diplomata DROP Image");
            Sql("ALTER TABLE Faculties DROP Image");
            Sql("ALTER TABLE Fields DROP Image");
            Sql("ALTER TABLE FinancialAids DROP Image");
            Sql("ALTER TABLE GovernmentSectors DROP Image");
            Sql("ALTER TABLE Learnership DROP Image");
            Sql("ALTER TABLE Schools DROP Image");
            Sql("ALTER TABLE Universities DROP Image");
        }
    }
}
