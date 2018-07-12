namespace Wihajster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameAndMainPicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "Name", c => c.String());
            AddColumn("dbo.Category", "MainPicture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "MainPicture");
            DropColumn("dbo.Category", "Name");
        }
    }
}
