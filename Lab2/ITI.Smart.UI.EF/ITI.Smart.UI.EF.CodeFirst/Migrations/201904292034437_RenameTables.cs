namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            RenameTable(name: "dbo.Countries", newName: "Country");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Country", newName: "Countries");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
