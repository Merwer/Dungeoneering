namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstFlagToMatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "First", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "First");
        }
    }
}
