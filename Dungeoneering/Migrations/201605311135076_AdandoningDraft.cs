namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdandoningDraft : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drafts", "Abandoned", c => c.Boolean(nullable: false));
            DropColumn("dbo.Drafts", "Complete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Drafts", "Complete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Drafts", "Abandoned");
        }
    }
}
