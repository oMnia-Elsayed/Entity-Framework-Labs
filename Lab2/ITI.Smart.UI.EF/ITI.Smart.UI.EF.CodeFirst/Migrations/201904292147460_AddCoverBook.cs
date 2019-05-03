namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoverBook : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "Book");
            CreateTable(
                "dbo.Cover",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Book", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cover", "Id", "dbo.Book");
            DropIndex("dbo.Cover", new[] { "Id" });
            AlterColumn("dbo.Book", "Title", c => c.String());
            DropTable("dbo.Cover");
            RenameTable(name: "dbo.Book", newName: "Books");
        }
    }
}
