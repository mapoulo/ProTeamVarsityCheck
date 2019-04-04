namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToFinancialAidTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into FinancialAids values('Hatch', 'Civil Engineering', ' ', ' ', 'https://jobs.hatch.com/job/Johannesburg-Bursary-Programme-Civil-Engineering-Bursary-Gaut/540856900/','~/imgz/Bursary/hatch.jpg')");
            Sql("insert into FinancialAids values('Hatch', 'Chemical Engineering', ' ', ' ', 'https://jobs.hatch.com/job/Johannesburg-Bursary-Programme-Chemical-Engineering-Bursary-Gaut/540857200/','~/imgz/Bursary/hatch.jpg')");
            Sql("insert into FinancialAids values('Hatch', 'Mechanical Engineering', ' ', ' ', 'https://jobs.hatch.com/job/Johannesburg-Bursary-Programme-Mechanical-Engineering-Bursary-Gaut/540857100/','~/imgz/Bursary/hatch.jpg')");
            Sql("insert into FinancialAids values('Hatch', 'Electrical Engineering', ' ', ' ', 'https://jobs.hatch.com/job/Johannesburg-Bursary-Programme-Electrical-Engineering-Bursary-Gaut/540857000/','~/imgz/Bursary/hatch.jpg')");
            Sql("insert into FinancialAids values('Lonmin', 'Engineering', ' ', ' ', 'http://lonmin.pnet.co.za/#s=static&x=graduates','~/imgz/Bursary/lonmin.jpg')");
            Sql("insert into FinancialAids values('Chieta', 'Chemical Engineering', ' ', ' ', 'mailto:bursary@chieta.org.za','~/imgz/Bursary/chieta.jpg')");
            Sql("insert into FinancialAids values('Asea Brown Boveri', 'Electrical Engineering', ' ', ' ', 'https://new.abb.com/jobs/details/ZA67776713_E4','~/imgz/Bursary/ABB.jpg')");
            Sql("insert into FinancialAids values('PSG', 'Engineering / Information Technology', ' ', ' ', 'http://www.psg.co.za/careers/site/careers/position-detail.php?position=2423','~/imgz/Bursary/psg.jpg')");
            Sql("insert into FinancialAids values('Shoprite', 'Finance', ' ', ' ', 'https://shoprite-bursary.erecruit.co/candidateapp/Jobs/View/181119-4/Bursary-_Accounting_(CA_Stream)_2019','~/imgz/Bursary/shoprite.jpg')");
            Sql("insert into FinancialAids values('Shoprite', 'Information Technology', ' ', ' ', 'https://shoprite-bursary.erecruit.co/candidateapp/Jobs/View/181119-1/Bursary-_Information_Technology_2019','~/imgz/Bursary/shoprite.jpg')");
            Sql("insert into FinancialAids values('Shoprite', 'Logistics / Supply Chain', ' ', ' ', 'https://shoprite-bursary.erecruit.co/candidateapp/Jobs/View/181119-2/Bursary-_Logistics_-_Supply_Chain_2019','~/imgz/Bursary/shoprite.jpg')");
            Sql("insert into FinancialAids values('Shoprite', 'Retail Business Management', ' ', ' ', 'https://shoprite-bursary.erecruit.co/candidateapp/Jobs/View/181119-3/Bursary-_Retail_Business_Management_2019','~/imgz/Bursary/shoprite.jpg')");
        }

        public override void Down()
        {
            Sql("delete from FinancialAids where Id=3");
            Sql("delete from FinancialAids where Id=4");
            Sql("delete from FinancialAids where Id=5");
            Sql("delete from FinancialAids where Id=6");
            Sql("delete from FinancialAids where Id=7");
            Sql("delete from FinancialAids where Id=8");
            Sql("delete from FinancialAids where Id=9");
            Sql("delete from FinancialAids where Id=10");
            Sql("delete from FinancialAids where Id=11");
            Sql("delete from FinancialAids where Id=12");
            Sql("delete from FinancialAids where Id=13");
            Sql("delete from FinancialAids where Id=14");
        }
    }
}
