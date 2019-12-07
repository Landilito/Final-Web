namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArregloFecha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.DateTime(nullable: false));
        }
    }
}
