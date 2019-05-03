namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserPassportRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passports", "PassUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Passports", "PassUserId");
            AddForeignKey("dbo.Passports", "PassUserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passports", "PassUserId", "dbo.Users");
            DropIndex("dbo.Passports", new[] { "PassUserId" });
            DropColumn("dbo.Passports", "PassUserId");
        }
    }
}
