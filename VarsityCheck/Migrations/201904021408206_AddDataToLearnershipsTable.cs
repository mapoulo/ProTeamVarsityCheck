namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToLearnershipsTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Learnerships values ('Lanseria Airport','~/imgz/learnership/lanseria.jpg','mailto:learnershipapplications@lanseria.co.za','Aviation Learnership') ");
            Sql("Insert into Learnerships values ('Transnet','~/imgz/learnership/transnet.jpg','https://recruiting.transnet.net/sap/bc/webdynpro/sap/hrrcf_a_posting_apply?PARAM=cG9zdF9pbnN0X2d1aWQ9OUEyOTQ2MzQ0QjEwMUVEOTkyREUwNTVFQjQyQkQ0MTYmY2FuZF90eXBlPUVYVA%3d%3d&sap-theme=sap_corbu&sap-client=400&sap-language=EN#','Track Master Apprenticeship') ");
            Sql("Insert into Learnerships values ('Transnet','~/imgz/learnership/transnet.jpg','https://recruiting.transnet.net/sap/bc/webdynpro/sap/hrrcf_a_posting_apply?PARAM=cG9zdF9pbnN0X2d1aWQ9OUEyOTQ2MzQ0QjEwMUVEOTkyREU5NEJFQjUyOTU0M0UmY2FuZF90eXBlPUVYVA%3d%3d&sap-theme=sap_corbu&sap-client=400&sap-language=EN#','Traction Lineman Apprenticeship') ");
            Sql("Insert into Learnerships values ('Transnet','~/imgz/learnership/transnet.jpg','https://recruiting.transnet.net/sap/bc/webdynpro/sap/hrrcf_a_posting_apply?PARAM=cG9zdF9pbnN0X2d1aWQ9OUEyOTQ2MzQ0QjEwMUVEOTkyRERCQ0MzNzc0NDEzQ0MmY2FuZF90eXBlPUVYVA%3d%3d&sap-theme=sap_corbu&sap-client=400&sap-language=EN#','Welder Apprenticeship') ");
            Sql("Insert into Learnerships values ('Lafarge','~/imgz/learnership/lafarge.jpg','mailto:learners@lafargeholcim.com','Boilermaking') ");
            Sql("Insert into Learnerships values ('Lafarge','~/imgz/learnership/lafarge.jpg','mailto:learners@lafargeholcim.com','Electrical') ");
            Sql("Insert into Learnerships values ('Lafarge','~/imgz/learnership/lafarge.jpg','mailto:learners@lafargeholcim.com','Fitting and Turning') ");
            Sql("Insert into Learnerships values ('Dept of Rural Development','~/imgz/learnership/Dept of Rural Development.jpg','https://drdlr.erecruit.co/candidateapp/Jobs/View/190126-2/Pupil_Geomatics_Officer_(Learnership)_(24_Month_Contract_Posts)','Pupil Geomatics Officer') ");
            Sql("Insert into Learnerships values ('Engen','~/imgz/learnership/engen.jpg','https://engen.graduate.erecruit.co/candidateapp/Jobs/View/190327-7/BCom_Forensic_Accountancy_Graduate','Forensic Accountancy') ");
            Sql("Insert into Learnerships values ('Engen','~/imgz/learnership/engen.jpg','https://engen.graduate.erecruit.co/candidateapp/Jobs/View/190327-24/BSc_Chemical_-_BSc_Mechanical_Engineering_Graduate','Chemical / Mechanical Engineering') ");
            Sql("Insert into Learnerships values ('Engen','~/imgz/learnership/engen.jpg','https://engen.graduate.erecruit.co/candidateapp/Jobs/View/190327-14/BCom_Taxation_-_BCom_Accounting_Graduate','Taxation / Accounting Graduate') ");
            Sql("Insert into Learnerships values ('Engen','~/imgz/learnership/engen.jpg','https://engen.graduate.erecruit.co/candidateapp/Jobs/View/190327-12/BSC_Computer_Science_(IT_Infrastructure_-_Cloud_Computing_Technologies)_Graduate','IT Infrastructure & Cloud Computing Technologies') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=1407317#jobDetails=1407317_5941','Training Contract 2020 Mafikeng/ Lichtenburg') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=799609#jobDetails=799609_5941','Training Contract 2020 Durban') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=799075#jobDetails=799075_5941','Training Contract 2020 Port Elizabeth') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=832145#jobDetails=832145_5941','Training Contract 2020 East London') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=869408#jobDetails=869408_5941','Training Contract 2020 Bloemfontein') ");
            Sql("Insert into Learnerships values ('Pricewaterhouse Coopers','~/imgz/learnership/pwc.jpg','https://krb-xjobs.brassring.com/TGnewUI/Search/home/HomeWithPreLoad?partnerid=30056&siteid=5941&PageType=JobDetails&jobid=734204#jobDetails=734204_5941','Training Contract 2020 - Cape Town') ");
        }

        public override void Down()
        {
            Sql("delete from Learnerships where id = 4 ");
            Sql("delete from Learnerships where id = 5 ");
            Sql("delete from Learnerships where id = 6 ");
            Sql("delete from Learnerships where id = 7 ");
            Sql("delete from Learnerships where id = 8 ");
            Sql("delete from Learnerships where id = 9 ");
            Sql("delete from Learnerships where id = 10 ");
            Sql("delete from Learnerships where id = 11");
            Sql("delete from Learnerships where id = 12");
            Sql("delete from Learnerships where id = 13");
            Sql("delete from Learnerships where id = 14 ");
            Sql("delete from Learnerships where id = 15");
            Sql("delete from Learnerships where id = 16");
            Sql("delete from Learnerships where id = 17 ");
            Sql("delete from Learnerships where id = 18");
            Sql("delete from Learnerships where id = 19");
            Sql("delete from Learnerships where id = 20");
            Sql("delete from Learnerships where id = 21");
        }
    }
}
