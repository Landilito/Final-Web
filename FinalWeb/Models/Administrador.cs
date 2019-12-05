using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalWeb.Models
{
    public class Administrador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}