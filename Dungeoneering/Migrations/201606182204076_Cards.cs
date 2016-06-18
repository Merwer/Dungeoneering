namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cards : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardContainers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Archetype = c.Int(nullable: false),
                        Rarity = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Rewards_Coins = c.Int(nullable: false),
                        Rewards_Attack = c.Int(nullable: false),
                        Rewards_Health = c.Int(nullable: false),
                        Rewards_Armour = c.Int(nullable: false),
                        Rewards_Weapon = c.Boolean(nullable: false),
                        Image = c.String(nullable: false),
                        Version = c.String(),
                        Active = c.Boolean(nullable: false),
                        Score = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Parent_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CardContainers", t => t.Parent_Id, cascadeDelete: true)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.CardScores",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Archetype = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Card_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id, cascadeDelete: true)
                .Index(t => t.Card_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CardScores", "Card_Id", "dbo.Cards");
            DropForeignKey("dbo.Cards", "Parent_Id", "dbo.CardContainers");
            DropIndex("dbo.CardScores", new[] { "Card_Id" });
            DropIndex("dbo.Cards", new[] { "Parent_Id" });
            DropTable("dbo.CardScores");
            DropTable("dbo.Cards");
            DropTable("dbo.CardContainers");
        }
    }
}
