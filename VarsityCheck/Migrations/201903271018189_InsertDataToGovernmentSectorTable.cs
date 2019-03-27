namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToGovernmentSectorTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into GovernmentSectors Values('South African Air Force','28 Jan 2019','28 Feb 2019','http://www.af.mil.za/application_form/Pilots%20Nav%2019.pdf','~/imgz/government/saadf.jpg')");
            Sql("Insert Into GovernmentSectors Values('South African Army','28 Jan 2019','28 Feb 2019','http://www.careers.mil.za/index.htm','~/imgz/government/saadf.jpg')");
            Sql("Insert Into GovernmentSectors Values('South African Military Health service','28 Jan 2019','28 Feb 2019','http://www.careers.mil.za/index.htm','~/imgz/government/samhs.jpg')");
            Sql("Insert Into GovernmentSectors Values('South African Navy','28 Jan 2019','28 Feb 2019','http://www.navy.mil.za/SANCareers/Default.htm','~/imgz/government/sanf.jpg')");
            Sql("Insert Into GovernmentSectors Values('South African Police Services','28 Jan 2019','28 Feb 2019','https://www.saps.gov.za/careers/careers.php','~/imgz/government/saps.jpg')");
        }
        
        public override void Down()
        {
            Sql("Delete From GovernmentSectors Where Id = 1)");
            Sql("Delete From GovernmentSectors Where Id = 2)");
            Sql("Delete From GovernmentSectors Where Id = 3)");
            Sql("Delete From GovernmentSectors Where Id = 4)");
            Sql("Delete From GovernmentSectors Where Id = 5)");
        }
    }
}
