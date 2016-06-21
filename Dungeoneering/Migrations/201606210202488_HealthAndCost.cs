namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HealthAndCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CardContainers", "ChronicleId", c => c.Int(nullable: false));
            AddColumn("dbo.CardContainers", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Cards", "Health", c => c.Int(nullable: false));
            AddColumn("dbo.Cards", "Cost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cards", "Cost");
            DropColumn("dbo.Cards", "Health");
            DropColumn("dbo.CardContainers", "Type");
            DropColumn("dbo.CardContainers", "ChronicleId");
        }
    }
}
