namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddDataToFinancialFieldTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into FinancialAidFields values(1,1)");
            Sql("Insert into FinancialAidFields values(1,2)");
            Sql("Insert into FinancialAidFields values(2,1)");
            Sql("Insert into FinancialAidFields values(2,2)");

        }

        public override void Down()
        {
            Sql("Delete from FinancialAidFields where FinancialAidId = 1");
            Sql("Delete from FinancialAidFields where FinancialAidId = 2");
        }
    }
}
