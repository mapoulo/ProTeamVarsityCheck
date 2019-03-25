namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureAndLinkDataToDegreeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/electrical.jpg', Links = 'Electrical' Where Id = 1");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/civil.jpg' , Links = 'Civil' Where Id = 2");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/industrial.jpg', Links = 'Industrial' Where Id = 3");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/Mining.jpg', Links = 'Mining' Where Id = 4");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/mechanical.jpg', Links = 'Mechanical' Where Id = 5");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/Chemical.jpg' , Links = 'Chemical' Where Id = 6");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/extraction.jpg' , Links = 'Extraction' Where Id = 7");
            Sql("Update Degrees set Image = '~/imgz/degrees/engineering/physical.jpg' , Links = 'Physical' Where Id = 8");
        }

        public override void Down()
        {
            Sql("Delete From Degrees Where Id = 1");
            Sql("Delete From Degrees Where Id = 2");
            Sql("Delete From Degrees Where Id = 3");
            Sql("Delete From Degrees Where Id = 4");
            Sql("Delete From Degrees Where Id = 5");
            Sql("Delete From Degrees Where Id = 6");
            Sql("Delete From Degrees Where Id = 7");
            Sql("Delete From Degrees Where Id = 8");
        }
    }
}
