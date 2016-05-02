namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnumerateRound : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rounds", "Option1", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Option2", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Option3", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Option4", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Option5", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Selected1", c => c.Int(nullable: false));
            AddColumn("dbo.Rounds", "Selected2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rounds", "Selected2");
            DropColumn("dbo.Rounds", "Selected1");
            DropColumn("dbo.Rounds", "Option5");
            DropColumn("dbo.Rounds", "Option4");
            DropColumn("dbo.Rounds", "Option3");
            DropColumn("dbo.Rounds", "Option2");
            DropColumn("dbo.Rounds", "Option1");
        }
    }
}
