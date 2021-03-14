namespace PequenoProdutor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuintaMigracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "ApplicationUserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "ApplicationUserID");
        }
    }
}
