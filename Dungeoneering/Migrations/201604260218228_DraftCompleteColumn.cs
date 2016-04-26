namespace Dungeoneering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DraftCompleteColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drafts", "Complete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drafts", "Complete");
        }
    }
}
