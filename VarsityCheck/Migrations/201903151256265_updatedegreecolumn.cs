namespace VarsityCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedegreecolumn : DbMigration
    {
        public override void Up()
        {
            Sql("Update degrees set Name ='~/imgz/degrees/engineering/Chemical.jpg' where Id = 1");
        }
        
        public override void Down()
        {
            Sql("Update  degrees set Name = 'Electrical Engineering' where Id = 1");
        }
    }
}
