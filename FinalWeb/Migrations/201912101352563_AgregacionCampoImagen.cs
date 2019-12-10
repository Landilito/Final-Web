namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregacionCampoImagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Socios", "Foto", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Socios", "Foto");
        }
    }
}
