namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosTelefono : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Socios", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "Telefono", c => c.Int(nullable: false));
        }
    }
}
