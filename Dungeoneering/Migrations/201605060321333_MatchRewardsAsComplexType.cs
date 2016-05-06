namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchRewardsAsComplexType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MatchRewards", "Match_Id", "dbo.Matches");
            DropIndex("dbo.MatchRewards", new[] { "Match_Id" });
            AddColumn("dbo.Matches", "Rewards_Copper", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "Rewards_Shards", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "Rewards_Packs", c => c.Int(nullable: false));
            DropTable("dbo.MatchRewards");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Matches", "Rewards_Packs");
            DropColumn("dbo.Matches", "Rewards_Shards");
            DropColumn("dbo.Matches", "Rewards_Copper");
            CreateIndex("dbo.MatchRewards", "Match_Id");
            AddForeignKey("dbo.MatchRewards", "Match_Id", "dbo.Matches", "Id", cascadeDelete: true);
        }
    }
}
