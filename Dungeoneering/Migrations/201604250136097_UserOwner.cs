namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserOwner : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Drafts", new[] { "PublicId" });
            DropIndex("dbo.Rounds", new[] { "PublicId" });
            AddColumn("dbo.Drafts", "OwnerName", c => c.String(nullable: false));
            AddColumn("dbo.Rounds", "OwnerName", c => c.String(nullable: false));
            DropColumn("dbo.Drafts", "PublicId");
            DropColumn("dbo.Rounds", "PublicId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rounds", "PublicId", c => c.Int(nullable: false));
            AddColumn("dbo.Drafts", "PublicId", c => c.Int(nullable: false));
            DropColumn("dbo.Rounds", "OwnerName");
            DropColumn("dbo.Drafts", "OwnerName");
            CreateIndex("dbo.Rounds", "PublicId", unique: true);
            CreateIndex("dbo.Drafts", "PublicId", unique: true);
        }
    }
}
