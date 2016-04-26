namespace Dungeoneering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredDraftOnRound : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rounds", "Draft_Id", "dbo.Drafts");
            DropIndex("dbo.Rounds", new[] { "Draft_Id" });
            AlterColumn("dbo.Rounds", "Draft_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Rounds", "Draft_Id");
            AddForeignKey("dbo.Rounds", "Draft_Id", "dbo.Drafts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rounds", "Draft_Id", "dbo.Drafts");
            DropIndex("dbo.Rounds", new[] { "Draft_Id" });
            AlterColumn("dbo.Rounds", "Draft_Id", c => c.Long());
            CreateIndex("dbo.Rounds", "Draft_Id");
            AddForeignKey("dbo.Rounds", "Draft_Id", "dbo.Drafts", "Id");
        }
    }
}
