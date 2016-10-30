namespace Merwer.Chronicle.Dungeoneering.Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsernameToUserid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drafts", "OwnerId", c => c.String(nullable: false));
            AddColumn("dbo.Rounds", "OwnerId", c => c.String(nullable: false));

            Sql("UPDATE dbo.Drafts SET OwnerId = u.Id FROM dbo.Drafts d INNER JOIN dbo.AspNetUsers u ON d.OwnerName = u.UserName;");
            Sql("UPDATE dbo.Rounds SET OwnerId = u.Id FROM dbo.Rounds r INNER JOIN dbo.AspNetUsers u ON r.OwnerName = u.UserName;");

            DropColumn("dbo.Drafts", "OwnerName");
            DropColumn("dbo.Rounds", "OwnerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rounds", "OwnerName", c => c.String(nullable: false));
            AddColumn("dbo.Drafts", "OwnerName", c => c.String(nullable: false));

            Sql("UPDATE dbo.Drafts SET OwnerName = u.UserName FROM dbo.Drafts d INNER JOIN dbo.AspNetUsers u ON d.OwnerId = u.Id;");
            Sql("UPDATE dbo.Rounds SET OwnerName = u.UserName FROM dbo.Rounds r INNER JOIN dbo.AspNetUsers u ON r.OwnerId = u.Id;");

            DropColumn("dbo.Rounds", "OwnerId");
            DropColumn("dbo.Drafts", "OwnerId");
        }
    }
}
