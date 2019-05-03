namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveForigenKeyFromCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });
            RenameColumn(table: "dbo.Cities", name: "CountryId", newName: "Country_Id");
            AlterColumn("dbo.Cities", "Country_Id", c => c.Int());
            CreateIndex("dbo.Cities", "Country_Id");
            AddForeignKey("dbo.Cities", "Country_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            AlterColumn("dbo.Cities", "Country_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Cities", name: "Country_Id", newName: "CountryId");
            CreateIndex("dbo.Cities", "CountryId");
            AddForeignKey("dbo.Cities", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
