namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkipDrafts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drafts", "DraftSkipped", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drafts", "DraftSkipped");
        }
    }
}
