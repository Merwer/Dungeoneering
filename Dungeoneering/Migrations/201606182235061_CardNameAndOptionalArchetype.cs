namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardNameAndOptionalArchetype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CardContainers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.CardContainers", "Archetype", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CardContainers", "Archetype", c => c.Int(nullable: false));
            DropColumn("dbo.CardContainers", "Name");
        }
    }
}
