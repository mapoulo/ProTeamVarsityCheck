namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURLtOcERTIFICATEStable : DbMigration
    {
        public override void Up()
        {
            Sql("update Certificates set URLs = 'https://docs.google.com/forms/d/e/1FAIpQLScnr5-L_SDjY0zZEN4STUcUsXH2cPs1bYrgVljX_icU6ck9Iw/viewform' WHERE id = 1");
            Sql("update Certificates set URLs = 'https://docs.google.com/forms/d/e/1FAIpQLScnr5-L_SDjY0zZEN4STUcUsXH2cPs1bYrgVljX_icU6ck9Iw/viewform' WHERE id = 2");
            Sql("update Certificates set URLs = 'https://docs.google.com/forms/d/e/1FAIpQLScnr5-L_SDjY0zZEN4STUcUsXH2cPs1bYrgVljX_icU6ck9Iw/viewform' WHERE id = 3");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Certificates WHERE id = 1");
            Sql("DELETE FROM Certificates WHERE id = 2");
            Sql("DELETE FROM Certificates WHERE id = 3");
        }
    }
}
