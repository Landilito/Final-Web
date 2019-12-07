using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalWeb.Models
{
    public class Administrador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}