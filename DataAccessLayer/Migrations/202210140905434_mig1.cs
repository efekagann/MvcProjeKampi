namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "WriterId" });
            DropIndex("dbo.Contents", new[] { "WriterId" });
            AlterColumn("dbo.Headings", "WriterId", c => c.Int());
            AlterColumn("dbo.Contents", "WriterId", c => c.Int());
            CreateIndex("dbo.Headings", "WriterId");
            CreateIndex("dbo.Contents", "WriterId");
            AddForeignKey("dbo.Headings", "WriterId", "dbo.Writers", "WriterId");
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "WriterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropIndex("dbo.Headings", new[] { "WriterId" });
            AlterColumn("dbo.Contents", "WriterId", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contents", "WriterId");
            CreateIndex("dbo.Headings", "WriterId");
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "WriterId", cascadeDelete: true);
            AddForeignKey("dbo.Headings", "WriterId", "dbo.Writers", "WriterId", cascadeDelete: true);
        }
    }
}
