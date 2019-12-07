namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosConfiguracionFechaSocios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Socios", "Nacimiento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "FechaIngreso", c => c.DateTime());
            AlterColumn("dbo.Socios", "Nacimiento", c => c.DateTime());
        }
    }
}
