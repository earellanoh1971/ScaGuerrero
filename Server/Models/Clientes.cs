using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Clientes
    {
        public int Id { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string EMail { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string AtnCobranza { get; set; }
        public string AtnVentas { get; set; }
        public int IdImagen { get; set; }
        public decimal Saldo { get; set; }
    }
}
