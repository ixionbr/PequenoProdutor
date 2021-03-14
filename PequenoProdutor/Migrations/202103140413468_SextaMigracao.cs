namespace PequenoProdutor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SextaMigracao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Produtoes", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Produtoes", "ApplicationUserID");
            DropColumn("dbo.Produtoes", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Produtoes", "ApplicationUserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtoes", "ApplicationUser_Id");
            AddForeignKey("dbo.Produtoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
