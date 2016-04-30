namespace Merwer.Chronicle.Dungeoneering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMatches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OpponentArchetype = c.Int(nullable: false),
                        Win = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Draft_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drafts", t => t.Draft_Id, cascadeDelete: true)
                .Index(t => t.Draft_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Draft_Id", "dbo.Drafts");
            DropIndex("dbo.Matches", new[] { "Draft_Id" });
            DropTable("dbo.Matches");
        }
    }
}
