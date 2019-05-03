namespace ITI.Smart.UI.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserCitiesRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserCities",
                c => new
                    {
                        FKUserId = c.Int(name: "FK-UserId", nullable: false),
                        FK_CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FKUserId, t.FK_CityId })
                .ForeignKey("dbo.Users", t => t.FKUserId, cascadeDelete: true)
                .ForeignKey("dbo.City", t => t.FK_CityId, cascadeDelete: true)
                .Index(t => t.FKUserId)
                .Index(t => t.FK_CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCities", "FK_CityId", "dbo.City");
            DropForeignKey("dbo.UserCities", "FK-UserId", "dbo.Users");
            DropIndex("dbo.UserCities", new[] { "FK_CityId" });
            DropIndex("dbo.UserCities", new[] { "FK-UserId" });
            DropTable("dbo.UserCities");
        }
    }
}
