namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosConfiguracionesFechaSocios2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Socios", "Nacimiento", c => c.String());
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.String());
            AlterColumn("dbo.Socios", "FechaSalida", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "FechaSalida", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Socios", "Nacimiento", c => c.DateTime(nullable: false));
        }
    }
}
