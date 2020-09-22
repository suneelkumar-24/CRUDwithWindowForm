namespace CRUDwithWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ImgUrl", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "ImgUrl");
        }
    }
}
