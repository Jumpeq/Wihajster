namespace Wihajster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnumCategoryName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "CategoryName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Category", "CategoryName", c => c.Int());
        }
    }
}
