namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToUniversityTableIncludingImages : DbMigration
    {
        public override void Up()
        {
            Sql("delete from Universities where name ='University of Johannesburg' ");
            Sql("delete from Universities where name ='University of Cape Town' ");
            Sql("delete from Universities where name ='University of Limpopo' ");
            Sql("delete from Universities where name ='University of KwaZulu-Natal' ");

            Sql("DBCC CHECKIDENT('Universities', RESEED, 0)");

            Sql("INSERT INTO Universities values('Cape Peninsula University of Technology','Western Cape','~/imgz/logos/cput.jpg')");
            Sql("INSERT INTO Universities values('Central University of Technology','Free State','~/imgz/logos/cut.jpg')");
            Sql("INSERT INTO Universities values('Durban University of Technology','KwaZulu Natal','~/imgz/logos/dut.jpg')");
            Sql("INSERT INTO Universities values('Nelson Mandela University','Eastern Cape','~/imgz/logos/mandela.jpeg')");
            Sql("INSERT INTO Universities values('Mangosuthu University of Technology','KwaZulu Natal','~/imgz/logos/mut.jpg')");
            Sql("INSERT INTO Universities values('North West University','North West','~/imgz/logos/nwu.jpg')");
            Sql("INSERT INTO Universities values('Rhodes University','Eastern Cape','~/imgz/logos/ru.jpg')");
            Sql("INSERT INTO Universities values('Sefako Makgatho University','Gauteng','~/imgz/logos/smu.jpg')");
            Sql("INSERT INTO Universities values('Sol Plaatje University','Northern Cape','~/imgz/logos/spu.jpg')");
            Sql("INSERT INTO Universities values('University of Stellenbosch','Western Cape','~/imgz/logos/sun.jpg')");
            Sql("INSERT INTO Universities values('Tshwane University of Technology','Gauteng','~/imgz/logos/tut.jpg')");
            Sql("INSERT INTO Universities values('University of Cape Town','Western Cape','~/imgz/logos/uct.jpg')");
            Sql("INSERT INTO Universities values('University of Fort Hare','Eastern Cape','~/imgz/logos/ufh.jpg')");
            Sql("INSERT INTO Universities values('University of the Free State','Free State','~/imgz/logos/ufs.jpg')");
            Sql("INSERT INTO Universities values('University of Johannesburg','Gauteng','~/imgz/logos/uj.jpg')");
            Sql("INSERT INTO Universities values('University of KwaZulu Natal','KwaZulu-Natal','~/imgz/logos/ukzn.jpg')");
            Sql("INSERT INTO Universities values('University of Limpopo','Limpopo','~/imgz/logos/ul.jpg')");
            Sql("INSERT INTO Universities values('University of Mpumalang','Mpumalanga','~/imgz/logos/ump.jpg')");
            Sql("INSERT INTO Universities values('University of South Africa','Gauteng','~/imgz/logos/unisa.jpg')");
            Sql("INSERT INTO Universities values('University of Venda','Limpopo','~/imgz/logos/univen.jpg')");
            Sql("INSERT INTO Universities values('University of Zululand','KwaZulu-Natal','~/imgz/logos/unizulu.jpg')");
            Sql("INSERT INTO Universities values('University of Pretoria','Gauteng','~/imgz/logos/up.jpg')");
            Sql("INSERT INTO Universities values('University of the Western Cape','Western Cape','~/imgz/logos/uwc.jpg')");
            Sql("INSERT INTO Universities values('Vaal University of Technology','Gauteng','~/imgz/logos/vut.jpg')");
            Sql("INSERT INTO Universities values('University of the Witwatersrand','Gauteng','~/imgz/logos/wits.jpg')");
            Sql("INSERT INTO Universities values('Walter Sisulu University','Eastern Cape','~/imgz/logos/wsu.jpg')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Universities WHERE Name = 'Cape Peninsula University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'Central University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'Durban University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'Nelson Mandela University'");
            Sql("DELETE FROM Universities WHERE Name = 'Mangosuthu University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'North West University'");
            Sql("DELETE FROM Universities WHERE Name = 'Rhodes University'");
            Sql("DELETE FROM Universities WHERE Name = 'Sefako Makgatho University'");
            Sql("DELETE FROM Universities WHERE Name = 'Sol Plaatje University'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Stellenbosch'");
            Sql("DELETE FROM Universities WHERE Name = 'Tshwane University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Cape Town'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Fort Hare'");
            Sql("DELETE FROM Universities WHERE Name = 'University of the Free State'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Johannesburg'");
            Sql("DELETE FROM Universities WHERE Name = 'University of KwaZulu Natal'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Limpopo'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Mpumalang'");
            Sql("DELETE FROM Universities WHERE Name = 'University of South Africa'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Venda'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Zululand'");
            Sql("DELETE FROM Universities WHERE Name = 'University of Pretoria'");
            Sql("DELETE FROM Universities WHERE Name = 'University of the Western Cape'");
            Sql("DELETE FROM Universities WHERE Name = 'Vaal University of Technology'");
            Sql("DELETE FROM Universities WHERE Name = 'University of the Witwatersrand'");
            Sql("DELETE FROM Universities WHERE Name = 'Walter Sisulu University'");
        }
    }
}
