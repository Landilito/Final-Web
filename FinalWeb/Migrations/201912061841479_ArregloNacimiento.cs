namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArregloNacimiento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Socios", "Nacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "Nacimiento", c => c.DateTime(nullable: false));
        }
    }
}
