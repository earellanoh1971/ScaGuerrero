using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Ventas
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public string Status { get; set; }
        public int? IdCliente { get; set; }
        public int? IdCiclo { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string FormaPago { get; set; }
        public string MetodoPago { get; set; }
        public string UsoCfdi { get; set; }
        public string Uuid { get; set; }
        public string Observaciones { get; set; }
        public decimal? Anticipo { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public bool? Timbrado { get; set; }
        public int? IdUsuario { get; set; }

        
    }
}
