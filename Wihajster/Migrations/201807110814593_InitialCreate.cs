namespace Wihajster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Prize = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Picture",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PictureId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Picture", "CategoryId", "dbo.Category");
            DropIndex("dbo.Picture", new[] { "CategoryId" });
            DropTable("dbo.Picture");
            DropTable("dbo.Category");
        }
    }
}
