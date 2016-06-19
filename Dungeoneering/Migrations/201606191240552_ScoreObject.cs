namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScoreObject : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cards", "Score");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cards", "Score", c => c.Int(nullable: false));
        }
    }
}
