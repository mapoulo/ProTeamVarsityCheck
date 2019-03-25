namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToLinksColumnInUniversityFacultiesTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update Universities set UrlHome = 'https://www.cput.ac.za/', UrlApply='https://www.cput.ac.za/study/apply' where Id = 1");
            Sql("Update Universities set UrlHome = 'https://www.cut.ac.za/', UrlApply='https://www.cut.ac.za/admission-online' where Id = 2");
            Sql("Update Universities set UrlHome = 'https://www.dut.ac.za/', UrlApply='http://www.cao.ac.za/Apply.aspx?content=Apply' where Id = 3");
            Sql("Update Universities set UrlHome = 'https://www.mandela.ac.za/', UrlApply='https://www.mandela.ac.za/Apply/Admission/How-do-I-apply' where Id = 4");
            Sql("Update Universities set UrlHome = 'https://www.mut.ac.za/', UrlApply='http://www.cao.ac.za/Apply.aspx?content=Apply' where Id = 5");
            Sql("Update Universities set UrlHome = 'https://www.nwu.ac.za/', UrlApply='http://studies.nwu.ac.za/studies/apply' where Id = 6");
            Sql("Update Universities set UrlHome = 'https://www.ru.ac.za/', UrlApply='https://ross.ru.ac.za/' where Id = 7");
            Sql("Update Universities set UrlHome = 'http://www.smu.ac.za/', UrlApply='http://www.smu.ac.za/students/registrations/' where Id = 8");
            Sql("Update Universities set UrlHome = 'https://www.spu.ac.za/', UrlApply='https://www.spu.ac.za/index.php/how-to-apply/' where Id = 9");
            Sql("Update Universities set UrlHome = 'http://www.sun.ac.za/english', UrlApply='https://web-apps.sun.ac.za/eAansoek2/alg2.jsp' where Id = 10");
            Sql("Update Universities set UrlHome = 'https://www.tut.ac.za/', UrlApply='https://tutprodi4ie.tut.ac.za/pls/prodi41/gen.gw1pkg.gw1view' where Id = 11");
            Sql("Update Universities set UrlHome = 'http://www.uct.ac.za/', UrlApply='https://applyonline.uct.ac.za/' where Id = 12");
            Sql("Update Universities set UrlHome = 'http://ufh.ac.za/', UrlApply='https://www.ufh.ac.za/Students/Pages/StudyUFH.aspx' where Id = 13");
            Sql("Update Universities set UrlHome = 'https://www.ufs.ac.za/', UrlApply='https://www.ufs.ac.za/prospective' where Id = 14");
            Sql("Update Universities set UrlHome = 'https://www.uj.ac.za/', UrlApply='https://www.uj.ac.za/studyatUJ/sec/Pages/Academic%20Application.aspx' where Id = 15");
            Sql("Update Universities set UrlHome = 'https://www.ukzn.ac.za/', UrlApply='http://applications.ukzn.ac.za/Homepage.aspx' where Id = 16");
            Sql("Update Universities set UrlHome = 'https://www.ul.ac.za/', UrlApply='https://www.ul.ac.za/index.php?Entity=How%20to%20complete%20a%20Form' where Id = 17");
            Sql("Update Universities set UrlHome = 'http://www.ump.ac.za/', UrlApply='https://ienabler.ump.ac.za/pls/mpumuni/w99pkg.mi_login' where Id = 18");
            Sql("Update Universities set UrlHome = 'https://www.unisa.ac.za/sites/corporate/default/', UrlApply='https://www.unisa.ac.za/sites/corporate/default/Apply-for-admission' where Id = 19");
            Sql("Update Universities set UrlHome = 'http://www.univen.ac.za/', UrlApply='http://www.univen.ac.za/how-to-apply/' where Id = 20");
            Sql("Update Universities set UrlHome = 'http://www.unizulu.ac.za/', UrlApply='http://www.unizulu.ac.za/student-zone/apply/' where Id = 21");
            Sql("Update Universities set UrlHome = 'https://www.up.ac.za/', UrlApply='https://www.up.ac.za/online-application' where Id = 22");
            Sql("Update Universities set UrlHome = 'https://www.uwc.ac.za/Pages/default.aspx', UrlApply='https://www.uwc.ac.za/Students/Admin/Pages/Online-Applications.aspx' where Id = 23");
            Sql("Update Universities set UrlHome = 'https://www.vut.ac.za/', UrlApply='https://www.vut.ac.za/undergraduate/' where Id = 24");
            Sql("Update Universities set UrlHome = 'https://www.wits.ac.za/', UrlApply='https://www.wits.ac.za/study-at-wits/' where Id = 25");
            Sql("Update Universities set UrlHome = 'http://www.wsu.ac.za/waltersisulu/', UrlApply='http://www.wsu.ac.za/waltersisulu/index.php/my-first-tertiary-qualification/' where Id = 26");
        }
        
        public override void Down()
        {
            Sql("delete from Universities where Id = 1 ");
            Sql("delete from Universities where Id = 2 ");
            Sql("delete from Universities where Id = 3 ");
            Sql("delete from Universities where Id = 4 ");
            Sql("delete from Universities where Id = 5 ");
            Sql("delete from Universities where Id = 6 ");
            Sql("delete from Universities where Id = 7 ");
            Sql("delete from Universities where Id = 8 ");
            Sql("delete from Universities where Id = 9 ");
            Sql("delete from Universities where Id = 10 ");
            Sql("delete from Universities where Id = 11 ");
            Sql("delete from Universities where Id = 12 ");
            Sql("delete from Universities where Id = 13 ");
            Sql("delete from Universities where Id = 14 ");
            Sql("delete from Universities where Id = 15 ");
            Sql("delete from Universities where Id = 16 ");
            Sql("delete from Universities where Id = 17 ");
            Sql("delete from Universities where Id = 18 ");
            Sql("delete from Universities where Id = 19 ");
            Sql("delete from Universities where Id = 20 ");
            Sql("delete from Universities where Id = 21 ");
            Sql("delete from Universities where Id = 22 ");
            Sql("delete from Universities where Id = 23 ");
            Sql("delete from Universities where Id = 24 ");
            Sql("delete from Universities where Id = 25 ");
            Sql("delete from Universities where Id = 26 ");
        }
    }
}
