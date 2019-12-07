namespace FinalWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Usuario = c.String(),
                        Contraseña = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        SociosID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.String(),
                        Direccion = c.String(),
                        Telefono = c.Int(nullable: false),
                        Sexo = c.String(),
                        Edad = c.Int(nullable: false),
                        Nacimiento = c.DateTime(nullable: false),
                        Afiliados = c.Int(nullable: false),
                        Membresia = c.Int(nullable: false),
                        LugarTrabajo = c.String(),
                        DireccionOficina = c.String(),
                        TelefonoOficina = c.String(),
                        Estado = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        FechaSalida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SociosID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Socios");
            DropTable("dbo.Administradors");
        }
    }
}
