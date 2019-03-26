namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToLearnershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Learnerships Values('Tshimologong Skills Academy','~/imgz/learnership/tshimogolong.jpg','https://docs.google.com/forms/d/e/1FAIpQLScnr5-L_SDjY0zZEN4STUcUsXH2cPs1bYrgVljX_icU6ck9Iw/viewform')");
            Sql("Insert Into Learnerships Values('The Digital Academy','~/imgz/learnership/theDA.jpg','https://apply.thedigitalacademy.co.za/')");
            Sql("Insert Into Learnerships Values('Umuzi','~/imgz/learnership/umuzi.jpg','https://www.umuzi.org/apply_welcomesignup')");
            
        }
        
        public override void Down()
        {
            Sql("Delete from Learnerships where Id = 1");
            Sql("Delete from Learnerships where Id = 2");
            Sql("Delete from Learnerships where Id = 3");
        }
    }
}
