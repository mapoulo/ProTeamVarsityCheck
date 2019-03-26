namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagesToFinancialAid : DbMigration
    {
        public override void Up()
        {
            Sql("Update FinancialAids set Image = '~/imgz/Bursary/FNB.jpg' where Id = 1");
            Sql("Update FinancialAids set Image = '~/imgz/Bursary/Truworths.jpg' where Id = 2");
        }
        
        public override void Down()
        {
            Sql("Delete From FinancialAids where Id = 1");
            Sql("Delete From FinancialAids where Id = 2");
        }
    }
}
