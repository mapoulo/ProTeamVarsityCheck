namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddDataToFinancialAidTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into FinancialAids values('First National Bank', 'FNB Fund Bursary', '01 May 2019', '30 September 2019', 'http://www.studietrust.co.za/')");
            Sql("insert into FinancialAids values('Truworths', 'Truworths Bursary', '10 January 2019', '30 October 2019', 'https://careers.truworths.co.za')");
        }

        public override void Down()
        {
            Sql("delete from FinancialAids where Company='First National Bank'");
            Sql("delete from FinancialAids where Company='Truworths'");
        }
    }
}
