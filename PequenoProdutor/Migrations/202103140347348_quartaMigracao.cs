namespace PequenoProdutor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quartaMigracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Produtoes", "ApplicationUser_Id");
            AddForeignKey("dbo.Produtoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Produtoes", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Produtoes", "ApplicationUser_Id");
        }
    }
}
