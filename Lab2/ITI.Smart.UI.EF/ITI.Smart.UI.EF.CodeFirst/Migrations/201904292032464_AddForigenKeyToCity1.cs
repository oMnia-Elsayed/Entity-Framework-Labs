namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForigenKeyToCity1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            RenameColumn(table: "dbo.Cities", name: "Country_Id", newName: "FK_CountryId");
            AlterColumn("dbo.Cities", "FK_CountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "FK_CountryId");
            AddForeignKey("dbo.Cities", "FK_CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "FK_CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "FK_CountryId" });
            AlterColumn("dbo.Cities", "FK_CountryId", c => c.Int());
            RenameColumn(table: "dbo.Cities", name: "FK_CountryId", newName: "Country_Id");
            CreateIndex("dbo.Cities", "Country_Id");
            AddForeignKey("dbo.Cities", "Country_Id", "dbo.Countries", "Id");
        }
    }
}
