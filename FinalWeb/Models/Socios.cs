using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalWeb.Models
{
    public class Socios
    {
        [Key]
        public int SociosID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public byte[] Foto { get; set; }
        public string Direccion { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        [DataType(DataType.Date)]
        public string Nacimiento { get; set; }
        public Afiliado Afiliados { get; set; }
        public Membresia Membresia { get; set; }
        public string LugarTrabajo { get; set; }
        public string DireccionOficina { get; set; }
        public string TelefonoOficina { get; set; }
        public Estado Estado { get; set; }
        [DataType(DataType.Date)]
        public string FechaIngreso { get; set; }
        [DataType(DataType.Date)]
        public string FechaSalida { get; set; }
    }

    public enum Afiliado
    {
        Madre, Padre, Pareja, Hijos, Otros
    }

    public enum Membresia
    {
        Basic, Silver, Gold, Black
    }

    public enum Estado
    {
        Activo, Inactivo
    }
}