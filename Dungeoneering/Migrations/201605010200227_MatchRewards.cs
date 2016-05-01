namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchRewards : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchRewards",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Match_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.Match_Id, cascadeDelete: true)
                .Index(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatchRewards", "Match_Id", "dbo.Matches");
            DropIndex("dbo.MatchRewards", new[] { "Match_Id" });
            DropTable("dbo.MatchRewards");
        }
    }
}
