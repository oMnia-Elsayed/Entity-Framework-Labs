namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityBook : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "FK_CountryId", "dbo.Country");
            RenameColumn(table: "dbo.UserCities", name: "FK-UserId", newName: "FK_UserId");
            RenameIndex(table: "dbo.UserCities", name: "IX_FK-UserId", newName: "IX_FK_UserId");
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.Id)
                .Index(t => t.Id);
            
            AddForeignKey("dbo.City", "FK_CountryId", "dbo.Country", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.City", "FK_CountryId", "dbo.Country");
            DropForeignKey("dbo.Books", "Id", "dbo.City");
            DropIndex("dbo.Books", new[] { "Id" });
            DropTable("dbo.Books");
            RenameIndex(table: "dbo.UserCities", name: "IX_FK_UserId", newName: "IX_FK-UserId");
            RenameColumn(table: "dbo.UserCities", name: "FK_UserId", newName: "FK-UserId");
            AddForeignKey("dbo.City", "FK_CountryId", "dbo.Country", "Id", cascadeDelete: true);
        }
    }
}
